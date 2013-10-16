using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Job
    {
        public int jobid { get; set; }
        public string title { get; set; }
        public string company { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int indexyear { get; set; }
        public string intro { get; set; }
        public string apps { get; set; }
    }
}