using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Nfrc
    {
        public int CpdId { get; set; }
        public string Cpd { get; set; }
        public double? GroupId { get; set; }
        public string ManufacturerProductCode { get; set; }
        public string FrameSashType { get; set; }
        public double? Ufactor { get; set; }
        public double? Shgc { get; set; }
        public double? Vt { get; set; }
        public double? CondensationResistance { get; set; }
        public double? GlazingLayers { get; set; }
        public string LowE { get; set; }
        public double? GapWidths { get; set; }
        public string Spacer { get; set; }
        public string GapFill { get; set; }
        public string Grid { get; set; }
        public double? Divider { get; set; }
        public string Tint { get; set; }
        public int? GlassId { get; set; }
        public int? SystemId { get; set; }
        public string GlassName { get; set; }
        public string UnitType { get; set; }
        public string SystemName { get; set; }
        public string ProductDescription { get; set; }
        public string FrameMaterial { get; set; }
        public bool? Tbreak { get; set; }
        public string Igu { get; set; }
    }
}
