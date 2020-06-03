using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Entities.Configuration
{
    public class ResourceVersionConfig : IEntityTypeConfiguration<ResourceVersion>
    {
        public void Configure(EntityTypeBuilder<ResourceVersion> entity)
        {
            entity.HasKey(p => p.ResourceVersionID);
            //entity.HasOne(p => p.GetResource).WithMany().HasForeignKey(r => r.ResourceID);
        }
    }
}