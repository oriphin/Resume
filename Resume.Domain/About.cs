using System.Collections.Generic;

namespace Resume.Domain
{
    public class About
    {
        private ICollection<Snapshot> _snapshots; 
        public About()
        {
            _snapshots = new List<Snapshot>();
        }
        public int AboutId { get; set; }
        public string Preface { get; set; }

        public virtual ICollection<Snapshot> Snapshots
        {
            get { return _snapshots; } 
            set { _snapshots = value; }
        }
    }
}