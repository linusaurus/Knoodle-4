using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Asset
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public int? ManuId { get; set; }
        public int? AssetClass { get; set; }
        public decimal? Price { get; set; }
        public string Location { get; set; }
        public int? SupplierId { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ManuPartNum { get; set; }
        public string Tag { get; set; }
    }
}
