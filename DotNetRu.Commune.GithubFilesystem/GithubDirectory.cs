﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetRu.Auditor.Storage.FileSystem;
using Octokit;

namespace DotNetRu.Commune.GithubFileSystem
{
    /// <summary>
    /// Virtual directory in github repository. Implements <see cref="IDirectory"/>
    /// </summary>
    public class GithubDirectory : IDirectory
    {
        private readonly IGitHubClient _gitHubClient;
        private readonly Repository _repository;
        private readonly Reference _branch;
        private IRepositoryContentsClient ContentsClient => _gitHubClient.Repository.Content;

        private GithubDirectory(IGitHubClient gitHubClient, Repository repository, Reference branch, string name, string fullName)
        {
            _gitHubClient = gitHubClient;
            _repository = repository;
            _branch = branch;
            Name = name;
            FullName = fullName;
        }

        /// <summary>
        /// Factory method for building root directory
        /// </summary>
        /// <param name="gitHubClient">Github client for this directory, stores authentication data in it</param>
        /// <param name="repository">repository, contents are accessed to</param>
        /// <param name="branch">branch in the reposiroty, to work with</param>
        /// <returns>new directory instance pointing to the root of content of this branch in this repository</returns>
        public static IDirectory ForRoot(IGitHubClient gitHubClient, Repository repository, Reference branch)
        {
            return new GithubDirectory(gitHubClient, repository, branch, string.Empty, string.Empty);
        }

        /// <inheritdoc />
        public ValueTask<bool> ExistsAsync() => throw new NotImplementedException();

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public string FullName { get; }

        /// <inheritdoc />
        public IDirectory GetDirectory(string childDirectoryName)
        {
            var childFullName = FullName switch
            {
                null => childDirectoryName,
                "" => childDirectoryName,
                {} s when s.EndsWith("/") => $"{FullName}{childDirectoryName}",
                _ => $"{FullName}/{childDirectoryName}"
            };
            return new GithubDirectory(_gitHubClient, _repository, _branch, childDirectoryName, childFullName);
        }

        /// <inheritdoc />
        public IFile GetFile(string childFileName) => throw new NotImplementedException();

        /// <inheritdoc />
        public async IAsyncEnumerable<IDirectory> EnumerateDirectoriesAsync()
        {
            var contents = await ContentsClient.GetAllContentsByRef(_repository.Id, FullName, _branch.Ref)
                .ConfigureAwait(false);
            foreach (var content in contents.Where(x => x.Type.Value == ContentType.Dir))
            {
                yield return new GithubDirectory(_gitHubClient, _repository, _branch, content.Name, content.Path);
            }
        }

        /// <inheritdoc />
        public IAsyncEnumerable<IFile> EnumerateFilesAsync() => throw new NotImplementedException();
    }
}