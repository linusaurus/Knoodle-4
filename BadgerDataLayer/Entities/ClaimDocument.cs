using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class ClaimDocument
    {
        public int ClaimDocumentId { get; set; }
        public string DocumentDesciption { get; set; }
        public string DocumentExtension { get; set; }
        public int? ClaimItemId { get; set; }

        public virtual ClaimItem ClaimItem { get; set; }
    }
}
