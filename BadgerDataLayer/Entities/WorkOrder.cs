using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class WorkOrder
    {
        public int? WorkOrderId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
