using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartClass
    {
        public PartClass()
        {
            Category = new HashSet<Category>();
        }

        public int PartClassId { get; set; }
        public string PartClass1 { get; set; }

        public virtual ICollection<Category> Category { get; set; }
    }
}
