using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class PartTypes
    {
        public int PartTypeId { get; set; }
        public string PartTypeName { get; set; }
        public int? Categoryid { get; set; }
    }
}
