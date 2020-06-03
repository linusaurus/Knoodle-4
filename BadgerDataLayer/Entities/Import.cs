using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Import
    {
        public string Cpd { get; set; }
        public short? GroupId { get; set; }
        public string ManufacturerProductCode { get; set; }
        public string FrameSashType { get; set; }
        public float? UFactor { get; set; }
        public float? Shgc { get; set; }
        public float? Vt { get; set; }
        public short? CondensationResistance { get; set; }
        public short? GlazingLayers { get; set; }
        public string LowE { get; set; }
        public float? GapWidths { get; set; }
        public string Spacer { get; set; }
        public string GapFill { get; set; }
        public string Grid { get; set; }
        public float? Divider { get; set; }
        public string Tint { get; set; }
    }
}
