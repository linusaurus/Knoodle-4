using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class SubAssemblyConfig : IEntityTypeConfiguration<SubAssembly>
    {
        public void Configure(EntityTypeBuilder<SubAssembly> entity)
        {
            entity.HasKey(p => p.SubAssemblyID);
            
        }
    }
}
