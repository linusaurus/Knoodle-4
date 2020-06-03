using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class InventoryConfig : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> entity)
        {
            entity.HasKey(e => e.StockTransactionID);

            entity.Property(e => e.Emp_id);
        }
    }
}