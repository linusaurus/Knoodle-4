using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Document
    {     
        public int DocId { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public DateTime? DateModified { get; set; }
     

        // Relationships
        public  IList<DocumentParts> DocumentParts { get; set; }
    }
}
