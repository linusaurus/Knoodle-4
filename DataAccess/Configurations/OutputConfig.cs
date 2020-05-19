using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class OutputConfig : IEntityTypeConfiguration<Output>
    {
        public void Configure(EntityTypeBuilder<Output> entity)
        {
            entity.HasKey(p => p.CutlistID);
            
        }
    }
}