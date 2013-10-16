using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Person
    {
        public int personid { get; set; }
        public string firstname { get; set; }
        public string secondname { get; set; }
        public Contact contact { get; set; }
        public About about { get; set; }
        public Location location { get; set; }
        public Resume resume { get; set; }
    }
}