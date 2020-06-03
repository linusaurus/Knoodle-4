using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class AssetConfig : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> entity)
        {
            entity.HasKey(k => k.AssetId);
            
            entity.Property(e => e.AssetId).HasColumnName("AssetID");

            entity.Property(e => e.AddedBy).HasMaxLength(60);

            entity.Property(e => e.AssetDescription).HasMaxLength(512);

            entity.Property(e => e.AssetName).HasMaxLength(120);

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.ManuId).HasColumnName("ManuID");

            entity.Property(e => e.ManuPartNum)
                .HasMaxLength(120)
                .IsFixedLength();

            entity.Property(e => e.ModifiedBy).HasMaxLength(60);

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.Tag).HasMaxLength(50);
        }
    }
}