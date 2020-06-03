using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class AttachmentConfig : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> entity)
        {
            entity.HasKey(e => e.AttachmentId);

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

            entity.Property(e => e.AttachmentDescription)
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.Ext)
                .HasMaxLength(5)
                .IsFixedLength();

            entity.Property(e => e.Filesource).HasColumnName("filesource");

            entity.Property(e => e.Src)
                .HasColumnName("src")
                .HasMaxLength(140)
                .IsUnicode(false);

            entity.HasOne(d => d.OrderNumNavigation)
                .WithMany(p => p.Attachment)
                .HasForeignKey(d => d.OrderNum)
                .HasConstraintName("FK_Attachment_PurchaseOrder");
        }
    }
}