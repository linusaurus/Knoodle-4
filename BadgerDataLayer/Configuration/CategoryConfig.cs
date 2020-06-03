using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasKey(e => e.Categoryid);
            
            //entity.Property(e => e.Categoryid)
            //        .HasColumnName("Category")
            //        .HasMaxLength(70)
            //        .IsFixedLength();

            //entity.Property(e => e.PartClassId).HasColumnName("PartClassID");

            //entity.HasOne(d => d.PartClass)
            //    .WithMany(p => p.Category)
            //    .HasForeignKey(d => d.PartClassId)
            //    .OnDelete(DeleteBehavior.Cascade)
            //    .HasConstraintName("FK_Category_PartClass");
        }
    }
}