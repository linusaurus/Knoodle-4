using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class ClaimItemConfig : IEntityTypeConfiguration<ClaimItem>
    {
        public void Configure(EntityTypeBuilder<ClaimItem> entity)
        {
            entity.HasKey(e => e.ClaimItemId);

            entity.Property(e => e.ClaimItemId).HasColumnName("ClaimItemID");

            entity.Property(e => e.Bcode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

            entity.Property(e => e.DefectDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.LineID).HasColumnName("LineID");

            entity.Property(e => e.PartID).HasColumnName("PartID");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        }
    }
}
   