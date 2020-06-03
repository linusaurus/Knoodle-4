using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class PartConfig : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> entity)
        {
            entity.HasKey(p => p.PartID);

            entity.HasOne(d => d.Supplier)
                .WithMany(p => p.Part)
                .HasForeignKey(d => d.SupplierId);
        }
    }
}