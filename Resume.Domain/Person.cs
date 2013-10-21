using System.Collections.Generic;
namespace Resume.Domain
{
    public class Person
    {
        private ICollection<Resume> _resumes;

        public Person()
        {
            _resumes = new List<Resume>();
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int ContactId { get; set; }
        public int AboutId { get; set; }
        public int LocationId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual About About { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Resume> Resumes
        {
            get { return _resumes; }
            set { _resumes = value; }
        }
    }
}