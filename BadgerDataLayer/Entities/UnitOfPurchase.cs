using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class UnitOfPurchase
    {
        public int UoPID { get; set; }
        public int PartID { get; set; }
        public int? Uid { get; set; }
        public string Uopname { get; set; }
        public decimal? UopcostUnit { get; set; }
        public decimal? Uopratio { get; set; }

        public virtual Part Part { get; set; }
    }
}
