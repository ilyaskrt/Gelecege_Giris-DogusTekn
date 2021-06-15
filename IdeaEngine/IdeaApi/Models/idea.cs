using System;

namespace IdeaApi.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public int Like { get; set; }
    }
}