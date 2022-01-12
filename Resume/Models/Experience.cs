using System;

namespace Resume.Models
{
    public class Experience
    {
        public string Institution { get; set; }
        public string Duration { get; set; }
        public DateTime IniDate { get; set; }
        public DateTime? FinDate { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string RefLinkLabel { get; set; }
        public string RefLink { get; set; }
    }
}