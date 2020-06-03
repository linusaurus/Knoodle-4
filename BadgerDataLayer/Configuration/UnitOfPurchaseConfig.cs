using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class UnitOfPurchaseConfig : IEntityTypeConfiguration<UnitOfPurchase>
    {
        public void Configure(EntityTypeBuilder<UnitOfPurchase> entity)
        {
            entity.HasKey(p => p.UoPID);
        }
    }
}