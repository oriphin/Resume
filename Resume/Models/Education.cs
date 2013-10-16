using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Education
    {
        public int educationid { get; set; }
        public string campus { get; set; }
        public string course { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string achivements { get; set; }
    }
}