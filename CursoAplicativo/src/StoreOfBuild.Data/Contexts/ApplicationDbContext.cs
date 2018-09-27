using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreOfBuild.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(eb =>
            {
                eb.Property(b => b.Name).HasColumnType("varchar(200)");
                eb.Property(b => b.Price).HasColumnType("decimal(10, 2)");
            });
        }

    }
}
