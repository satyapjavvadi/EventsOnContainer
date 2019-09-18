using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<CatalogCategory> CatalogCategories { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }

        protected override void OnModelCreating(ModelBuilder eventModelBuilder)
        {
            eventModelBuilder.Entity<CatalogCategory>(ConfigureCatalogCategory);
            eventModelBuilder.Entity<CatalogType>(ConfigureCatalogType);
            eventModelBuilder.Entity<CatalogItem>(ConfigureCatalogItem);
        }

        private void ConfigureCatalogCategory(EntityTypeBuilder<CatalogCategory> obj)
        {
            throw new NotImplementedException();
        }

        private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> obj)
        {
            throw new NotImplementedException();
        }

        private void ConfigureCatalogItem(EntityTypeBuilder<CatalogItem> obj)
        {
            throw new NotImplementedException();
        }
    }
}
