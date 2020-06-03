using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class PurchaseOrderConfig : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> entity)
        {
            entity.HasKey(p => p.OrderNum);

            entity.Property(e => e.AddedBy)
                   .HasMaxLength(60)
                   .IsFixedLength();

            entity.Property(e => e.DateAdded).HasColumnType("date");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.ExpectedDate)
                .HasColumnName("Expected_Date")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsBackOrder).HasDefaultValueSql("((0))");

            entity.Property(e => e.JobId).HasColumnName("Job_id");

            entity.Property(e => e.Memo)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(60)
                .IsFixedLength();

            entity.Property(e => e.ModifiedDate).HasColumnType("date");

            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.OrderFormat).HasMaxLength(50);

            entity.Property(e => e.OrderState).HasDefaultValueSql("((1))");

            entity.Property(e => e.OrderTotal)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");

            entity.Property(e => e.RecievedDate).HasColumnType("datetime");

            entity.Property(e => e.SalesRep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");

            entity.Property(e => e.ShipId)
                .HasColumnName("ShipID")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ShippingCost)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.SubTotal)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SuppressTax).HasDefaultValueSql("((0))");

            entity.Property(e => e.Tax)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.HasMany(d => d.OrderFee)
                .WithOne(e => e.PurchaseOrder)
                .HasForeignKey(p => p.PurchaseOrderID);

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_PurchaseOrder_Employee");

            entity.HasOne(d => d.Job)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_PurchaseOrder_Job");

            entity.HasOne(d => d.Supplier)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_PurchaseOrder_Supplier");
        }
    }
}