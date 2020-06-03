using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public string AttachmentDescription { get; set; }
        public int? OrderNum { get; set; }
        public string Ext { get; set; }
        public string Src { get; set; }
        public byte[] Filesource { get; set; }
        public string Creator { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileSize { get; set; }

        public virtual PurchaseOrder OrderNumNavigation { get; set; }
    }
}
