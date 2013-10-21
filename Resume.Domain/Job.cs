namespace Resume.Domain
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int IndexYear { get; set; }
        public string Intro { get; set; }
        public string Apps { get; set; }
        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }
    }
}