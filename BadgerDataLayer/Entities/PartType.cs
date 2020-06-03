using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartType
    {
        public PartType()
        {
            Part = new HashSet<Part>();
        }

        public int PartTypeId { get; set; }
        public string PartType1 { get; set; }
        public int? Categoryid { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Part> Part { get; set; }
    }
}
