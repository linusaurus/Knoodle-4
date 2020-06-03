using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class DeadParts
    {
        public int PartID { get; set; }
        public string ItemDescription { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
