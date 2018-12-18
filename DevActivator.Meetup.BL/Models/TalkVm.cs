using System.Collections.Generic;
using DevActivator.Meetup.BL.Entities;

namespace DevActivator.Meetup.BL.Models
{
    public class TalkVm
    {
        public string Id { get; set; }

        public List<SpeakerReference> SpeakerIds { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CodeUrl { get; set; }

        public string SlidesUrl { get; set; }

        public string VideoUrl { get; set; }
    }
}