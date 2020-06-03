using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public int CurrentVersion { get; set; }

        // relationship child collection ----------------
        public List<ResourceVersion> Versions { get; set; } = new List<ResourceVersion>();

    }


  
}
