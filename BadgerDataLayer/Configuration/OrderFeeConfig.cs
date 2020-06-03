using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configuration
{
    public class OrderFeeConfig : IEntityTypeConfiguration<OrderFee>
    {
        public void Configure(EntityTypeBuilder<OrderFee> entity)
        {
            entity.HasKey(k => k.OrderfeeID);

           
        }
    }
}
