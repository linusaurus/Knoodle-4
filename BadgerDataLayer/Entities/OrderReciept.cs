using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class OrderReciept
    {
        public OrderReciept()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int OrderReceiptId { get; set; }
        public int? EmployeeId { get; set; }
        public int? OrderNum { get; set; }
        public DateTime? ReceiptDate { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
