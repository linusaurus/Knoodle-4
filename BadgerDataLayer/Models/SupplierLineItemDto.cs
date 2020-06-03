using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class SupplierLineItemDto
    {
        public string Description { get; set; }
        public int PartID { get; set; }
        public int LineID { get; set; }
        public decimal Qnty { get; set; }       
        public decimal UnitCost { get; set; }
        public int OrderNum { get; set; }
    }
}
