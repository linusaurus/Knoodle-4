using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class OrderListDto
    {
        public int OrderNum { get; set; }
        public DateTime OrderDate { get; set; }     
        public string Supplier { get; set; }
        public string Purchaser { get; set; }
        public string JobName { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool Recieved { get; set; }
    }
}
