using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class StockBillItem
    {
        public int StockItemID { get; set; }
        public int? ProductID { get; set; }
        public int SubAssemblyID { get; set; }
        public int? PartID { get; set; }
        public int? LineItemSourceID { get; set; }
        public decimal? Qnty { get; set; }
        public string Description { get; set; }

        public Assembly GetAssembly { get; set; }
    }
}
