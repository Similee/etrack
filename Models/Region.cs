using System;
using System.Collections.Generic;

namespace eTrack.Models
{
    public partial class Region
    {
        public Region()
        {
            Department = new HashSet<Department>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<Department> Department { get; set; }
    }
}
