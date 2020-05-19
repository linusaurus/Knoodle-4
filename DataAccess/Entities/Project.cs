using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string JobName { get; set; }
        public int? JobNumber { get; set; }
        public string DataPath { get; set; }
    }

}
