using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Location
    {
        public int locationid { get; set; }
        public string streetnumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int postcode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string description { get; set; }
    }
}