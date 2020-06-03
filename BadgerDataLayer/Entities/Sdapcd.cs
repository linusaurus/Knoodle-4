using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Sdapcd
    {
        public int Id { get; set; }
        public int? SdapcdId { get; set; }
        public decimal? BoilingPoint { get; set; }
        public decimal? VocContent { get; set; }
        public decimal? MixRatio { get; set; }
        public decimal? VocLimit { get; set; }
        public int? PartID { get; set; }
    }
}
