using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public void Configure(EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(e =>new { e.DocId, e.PartID});

            entity.HasOne(pt => pt.Doc)
                .WithMany(p => p.DocumentParts)
                .HasForeignKey(pt => pt.DocId);

            entity.HasOne(pt => pt.Part)
                .WithMany(t => t.DocumentParts)
                .HasForeignKey(pt => pt.PartID);


        }
    }
}
   