using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using DataAccess.Configurations;
using System;

namespace DataAccess
{
    public class BadgerContext : DbContext
    {
        private const string ConnectionString = @"Server=192.168.10.3;database=Badger;uid=sa;pwd=Kx09a32x;";

        public BadgerContext() : base()
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

        }

        public virtual DbSet<Job> Job {get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<Product> Assembly { get; set; }
        public virtual DbSet<SubAssembly> SubAssembly { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobConfig());
            modelBuilder.ApplyConfiguration(new PartConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            //modelBuilder.ApplyConfiguration(new OutputConfig());

        }
    }

   
}
