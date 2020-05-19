using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class PartConfig : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> entity)
        {
            entity.HasKey(p => p.PartID);
           
        }
    }
}
