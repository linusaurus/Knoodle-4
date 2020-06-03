using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class ProductionGroup
    {
        public ProductionGroup()
        {
            Assembly = new HashSet<Assembly>();
        }

        public int ProductionGroupId { get; set; }
        public string ProductionGroupName { get; set; }
        public int? JobId { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsContracted { get; set; }

        public virtual ICollection<Assembly> Assembly { get; set; }
    }
}
