using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Notification
    {
        public int NotifyId { get; set; }
        public int? OrderNum { get; set; }
        public string Notification1 { get; set; }

        public virtual PurchaseOrder OrderNumNavigation { get; set; }
    }
}
