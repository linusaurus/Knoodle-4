using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class WorkOrderRouting
    {
        public int WorkOrderId { get; set; }
        public int? ProductId { get; set; }
        public int? OperationSequence { get; set; }
        public int? LocationId { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? TaskId { get; set; }
    }
}
