using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Assembly
    {
        public int ProductId { get; set; }
        public int JobID { get; set; }
        public int AssemblyId { get; set; }
        public string AssemblyName { get; set; }
        public string ArchRef { get; set; }
        public int? ProductionGroupId { get; set; }
        public DateTime? ProductionDate { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public string Note { get; set; }
        public bool? Make { get; set; }
        public decimal? Perimeter { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Area { get; set; }
        public decimal? CalculatedCost { get; set; }
        public decimal? LaborHours { get; set; }   
        public bool? IsContracted { get; set; }

        public ICollection<SubAssembly> SubAssembly { get; set; }
        public ICollection<StockBillItem> StockBillItems { get; set; }
    }
}
