using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    public class OrderReceiptDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public int OrderReceiptId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int OrderNum { get; set; }
        public DateTime? ReceiptDate { get; set; }

        public virtual IList<InventoryItemDto> InventoryItems { get; set; }

    }

}

