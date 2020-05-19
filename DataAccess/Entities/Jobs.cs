using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Job
    {
        public Job()
        {
           // this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int job_id { get; set; }
        public int? company_id { get; set; }
        public int? project_id { get; set; }
        public int? structurelevel { get; set; }
        public string jobname { get; set; }
        public int? jobnumber { get; set; }
        public string jobdesc { get; set; }
        public int? leftNode { get; set; }
        public int? rightnode { get; set; }
        public int? parent_id { get; set; }
        public bool? Retired { get; set; }
        public int? Manager { get; set; }
        public bool? Visible { get; set; }

        public DateTime start_ts { get; set; }

       // public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
