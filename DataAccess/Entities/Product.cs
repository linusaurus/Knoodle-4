using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public string ArchDescription { get; set; }
        public bool? Make { get; set; }
        public decimal? W { get; set; }
        public decimal? H { get; set; }
        public decimal? D { get; set; }
        public string RoomName { get; set; }
        public int? JobID { get; set; }      
        public bool? Delivered { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public bool? NIC { get; set; }

        public ICollection<SubAssembly> SubAssembly { get; set; } = new HashSet<SubAssembly>();
    }

}
