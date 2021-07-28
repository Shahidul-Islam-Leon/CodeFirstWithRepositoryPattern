
using CodeFirstWithRepositoryPattern.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstWithRepositoryPattern.Models
{
    public class CFInventoryDbContext:DbContext
    {

        public CFInventoryDbContext():base("CFInventoryDb")
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CFInventoryDbContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CFInventoryDbContext,Configuration>());
        }
      public DbSet<Product> Products { get; set; }
      public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                        .HasKey<int>(k => k.CategoryId);

            modelBuilder.Entity<Product>()
                        .HasKey<int>(k => k.ProductId);

            modelBuilder.Entity<Product>()
                        .Property(k => k.ProductName)
                    
                        .IsRequired();
        }
    }
}