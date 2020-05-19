using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using DataAccess.Configurations;
using System;

namespace DataAccess
{
    public class ProductionContext : DbContext
    {
        private const string ConnectionString = @"Server=192.168.10.3;database=Production;uid=sa;pwd=Kx09a32x;";

        public ProductionContext() : base()
        { }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);         
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SubAssembly> SubAssembly { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Output> Output { get; set; }

        public virtual DbSet<Job> Job { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new SubAssemblyConfig());
            modelBuilder.ApplyConfiguration(new OutputConfig());
            modelBuilder.ApplyConfiguration(new JobConfig());

        }
    }

   
}
