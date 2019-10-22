using System;
using System.Collections.Generic;

namespace eTrack.Models
{
    public partial class AssetDetails
    {
        public int AssetDetailsId { get; set; }
        public string AssetUniqueId { get; set; }
        public string AssetSerialNumber { get; set; }
        public string AssetModel { get; set; }
        public DateTime? AssetTimeOfPurchase { get; set; }
        public int? AssetTypeId { get; set; }
        public int? AssetConditionId { get; set; }
        public int? ProductId { get; set; }
        public string AssetOs { get; set; }
        public int? DepartmentId { get; set; }
        public int? RegionId { get; set; }
        public string NameOfAssetUser { get; set; }
        public string AdditionalInformation { get; set; }
        public int? AssetStatusId { get; set; }
        public int? AssetActive { get; set; }

        public virtual Department Department { get; set; }
    }
}
