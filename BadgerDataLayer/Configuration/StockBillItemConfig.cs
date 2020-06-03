using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class StockBillItemConfig : IEntityTypeConfiguration<StockBillItem>
    {
        public void Configure(EntityTypeBuilder<StockBillItem> entity)
        {
            entity.HasKey(k => k.StockItemID);
        }
    }
}
