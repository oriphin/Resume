namespace Resume.Domain
{
    public class Education
    {
        public int Educationid { get; set; }
        public string Campus { get; set; }
        public string Course { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Achivements { get; set; }
        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }
    }
}