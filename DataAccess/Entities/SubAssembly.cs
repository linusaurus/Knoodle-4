using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class SubAssembly
    {
        public int ProductID { get; set; }
        public int SubAssemblyID { get; set; }
        public string SubAssemblyName { get; set; }
        public string MakeFile { get; set; }
        public decimal? W { get; set; }
        public decimal? H { get; set; }
        public decimal? D { get; set; }

        public int? GlassPartID { get; set; }
        public int? CPD_id { get; set; }

        public List<Part> Parts { get; set; }
       
        
    }
}
