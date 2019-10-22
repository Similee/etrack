using System;
using System.Collections.Generic;

namespace eTrack.Models
{
    public partial class Department
    {
        public Department()
        {
            AssetDetails = new HashSet<AssetDetails>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<AssetDetails> AssetDetails { get; set; }
    }
}
