using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class AssemblyConfig : IEntityTypeConfiguration<Assembly>
    {
        public void Configure(EntityTypeBuilder<Assembly> entity)
        {
            entity.HasKey(p => p.ProductId);
            entity.HasMany(p => p.SubAssembly).WithOne(r => r.GetAssembly).HasForeignKey(f => f.AssemblyId);
            entity.HasMany(p => p.StockBillItems).WithOne(p => p.GetAssembly).HasForeignKey(f => f.ProductID);
        }
    }
}