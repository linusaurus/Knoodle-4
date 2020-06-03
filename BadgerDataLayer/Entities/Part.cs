using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Part
    {
        
        public int PartID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string PartNum { get; set; }
        public int? ManuId { get; set; }
        public bool? ObsoluteFlag { get; set; }
        public int? PartTypeId { get; set; }
        public decimal? Cost { get; set; }
        public string Uop { get; set; }
        public decimal? Uopcost { get; set; }
        public int? UID { get; set; }
        public string Location { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Waste { get; set; }
        public decimal? MarkUp { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierDescription { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? UseSupplierNameFlag { get; set; }
        public decimal? UnitToPurchaseFactor { get; set; }
        public string ManuPartNum { get; set; }
        public string Sku { get; set; }
        public bool? Carbtrack { get; set; }
        public string Carblevel { get; set; }
        public int? ParentId { get; set; }
        public decimal? Amount_Required { get; set; }

        public virtual PartType PartType { get; set; }
        public virtual Supplier Supplier { get; set; }
        //public virtual UnitOfMeasure U { get; set; }
        
        public IList<DocumentParts> DocumentParts { get; set; }
        public IList<UnitOfPurchase> UnitOfPurchase { get; set; }
    }
}
