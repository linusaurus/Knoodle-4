/* *********************************
        Joining table for Part
        and documents
*/
using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class DocumentParts
    {
        public int PartID { get; set; }
        public int DocId { get; set; }

        public  Document Doc { get; set; }
        public  Part Part { get; set; }
    }
}
