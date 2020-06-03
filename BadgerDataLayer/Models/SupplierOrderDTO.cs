using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
   
        public class SupplierOrderDTO
        {
            public SupplierOrderDTO() { }

            public override string ToString()
            {
                return JobName;
            }
            private int? orderNum;
            private string supplierName;
            private string jobName;
            private DateTime? orderDate;
            private bool? received;
            private string purchaserName;
            private string receiveStatus;

            public int? OrderNum { get => OrderNum1; set => OrderNum1 = value; }
            public string ReceiveStatus { get => ReceiveStatus1; set => ReceiveStatus1 = value; }
            public string PurchaserName { get => PurchaserName1; set => PurchaserName1 = value; }
            public string ReceiveStatus1 { get => receiveStatus; set => receiveStatus = value; }
            public string PurchaserName1 { get => purchaserName; set => purchaserName = value; }
            public bool? Received { get => received; set => received = value; }
            public DateTime? OrderDate { get => orderDate; set => orderDate = value; }
            public string JobName { get => jobName; set => jobName = value; }
            public string SupplierName { get => supplierName; set => supplierName = value; }
            public int? OrderNum1 { get => orderNum; set => orderNum = value; }

        }
    
}
