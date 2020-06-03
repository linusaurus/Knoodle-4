using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class ClaimDocumentConfig : IEntityTypeConfiguration<ClaimDocument>
    {
        public void Configure(EntityTypeBuilder<ClaimDocument> entity)
        {
            entity.HasKey(e => e.ClaimDocumentId);
            
            entity.Property(e => e.ClaimDocumentId).HasColumnName("ClaimDocumentID");

            entity.Property(e => e.ClaimItemId).HasColumnName("ClaimItemID");

            entity.Property(e => e.DocumentDesciption)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DocumentExtension)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.ClaimItem)
                .WithMany(p => p.ClaimDocument)
                .HasForeignKey(d => d.ClaimItemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClaimDocument_ClaimItem");
        }
    }
}
