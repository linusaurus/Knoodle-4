using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class WorkCenter
    {
        public int? WorkCenterId { get; set; }
        public string WorkCenterName { get; set; }
        public decimal? CostRate { get; set; }
        public decimal? Availabilty { get; set; }
    }
}
