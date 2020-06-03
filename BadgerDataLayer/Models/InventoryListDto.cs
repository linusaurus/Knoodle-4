using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class InventoryListDto
    {
        public int StockTransactionId { get; set; }
        public int OrderReceiptId { get; set; }
        public int LineID { get; set; }
        public int PartID { get; set; }
        public string TransDate { get; set; }
        public decimal QntyRev { get; set; }
        public string Description { get; set; }
        public string JobName { get; set; }
        public int TransactionType { get; set; }

       
    }
}
