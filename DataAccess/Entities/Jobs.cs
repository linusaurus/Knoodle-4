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

        public int JobID { get; set; }
       
        public string JobName{ get; set; }
        public int? JobNumber { get; set; }
        public string JobDescription { get; set; }
 
        public bool? Visible { get; set; }

        public DateTime start_ts { get; set; }

       // public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
