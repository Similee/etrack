using System;
using System.Collections.Generic;

namespace eTrack.Models
{
    public partial class AssetHistory
    {
        public int AssetHistoryId { get; set; }
        public string AssetHistoryUniqueId { get; set; }
        public string AssetHistorySerialNumber { get; set; }
        public string AssetHistoryModel { get; set; }
        public DateTime? AssetHistoryTimeOfPurchase { get; set; }
        public int? AssetHistoryTypeId { get; set; }
        public int? AssetHistoryConditionId { get; set; }
        public int? AssetHistoryProductId { get; set; }
        public string AssetHistoryAssetOs { get; set; }
        public int? AssetHistoryDepartmentId { get; set; }
        public int? AssetHistoryRegionId { get; set; }
        public string AssetHistoryNameOfAssetUser { get; set; }
        public string AssetHistoryAdditionalInformation { get; set; }
        public int? AssetHistoryAssetStatusId { get; set; }
        public int? AssetHistoryAssetActive { get; set; }
    }
}
