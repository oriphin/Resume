using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Snapshot
    {
        public int snapshotid { get; set; }
        public string title { get; set; }
        public string icon { get; set; }
        public string details { get; set; }
    }
}