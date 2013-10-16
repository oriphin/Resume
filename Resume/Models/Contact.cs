using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Contact
    {
        public int contactid { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string preface { get; set; }
    }
}