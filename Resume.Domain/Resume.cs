using System.Collections.Generic;
using System.Data.Common;

namespace Resume.Domain
{
    public class Resume
    {
        private ICollection<Job> _jobs;
        private ICollection<Education> _educations; 
        public Resume()
        {
            _jobs = new List<Job>();
            _educations = new List<Education>();
        }
        public int ResumeId { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }

        public virtual ICollection<Education> Educations
        {
            get { return _educations; }
            set { _educations = value; }
        }

    }
}