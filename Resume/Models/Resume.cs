using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Resume
    {
        public int resumeid { get; set; }
        public ICollection<Job> jobs { get; set; }
        public ICollection<Education> educations { get; set; }
    }
}