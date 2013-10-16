using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class About
    {
        public int aboutid { get; set; }
        public string preface { get; set; }
        public ICollection<Snapshot> snapshots { get; set; }
    }
}