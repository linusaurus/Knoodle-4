using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class ResourceVersion
    {
        public int ResourceVersionID { get; set; }
        public int ResourceID { get; set; }
        public int RVersion { get; set; }
        public string VersionComment { get; set; }
        public Byte[] Resource { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModDate { get; set; }

        // relationships ------------------------------

        public Resource GetResource { get; set; }
    }
}
