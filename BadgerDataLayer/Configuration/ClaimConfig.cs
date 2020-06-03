using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class ClaimConfig : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> entity)
        {
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

            entity.Property(e => e.ClaimDate).HasColumnType("date");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierOrder)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
