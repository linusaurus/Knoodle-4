using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Job
    {
        public Job()
        {
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int JobId { get; set; }
        public int? CompanyId { get; set; }
        public int? ProjectId { get; set; }
        public int? Structurelevel { get; set; }
        public string Jobname { get; set; }
        public int? Jobnumber { get; set; }
        public string Jobdesc { get; set; }
        public int? LeftNode { get; set; }
        public int? Rightnode { get; set; }
        public int? ParentId { get; set; }
        public bool? Retired { get; set; }
        public int? Manager { get; set; }
        public bool? Visible { get; set; }
        public DateTime? start_ts { get; set; }
        

        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
