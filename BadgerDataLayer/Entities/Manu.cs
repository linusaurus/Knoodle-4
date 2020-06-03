using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Manu
    {
        public int ManuId { get; set; }
        public string Manufacturer { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public int? ManuCategoryId { get; set; }
    }
}
