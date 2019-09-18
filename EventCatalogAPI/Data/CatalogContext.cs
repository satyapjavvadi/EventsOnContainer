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

        private void ConfigureCatalogCategory(EntityTypeBuilder<CatalogCategory> categoryBuilder)
        {
            categoryBuilder.ToTable("CatalogCategories");
            categoryBuilder.Property(c => c.ID).IsRequired().ForSqlServerUseSequenceHiLo("catalog_category_hilo");
            categoryBuilder.Property(c => c.Category).IsRequired().HasMaxLength(100);
            
        }

        private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> typeBuilder)
        {
            typeBuilder.ToTable("CatalogTypes");
            typeBuilder.Property(t => t.ID).IsRequired().ForSqlServerUseSequenceHiLo("catalog_type_hilo");
            typeBuilder.Property(t => t.Type).IsRequired().HasMaxLength(100);
        }

        private void ConfigureCatalogItem(EntityTypeBuilder<CatalogItem> itemBuilder)
        {
            itemBuilder.ToTable("Events");
            itemBuilder.Property(e => e.Id).IsRequired().ForSqlServerUseSequenceHiLo("events_hilo");
            itemBuilder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            itemBuilder.Property(e => e.Information).IsRequired();
            itemBuilder.Property(e => e.AddressLineOne).IsRequired();
            itemBuilder.Property(e => e.AddressLineTwo).HasMaxLength(100);
            itemBuilder.Property(e => e.City).IsRequired().HasMaxLength(100);
            itemBuilder.Property(e => e.State).IsRequired().HasMaxLength(50);
            itemBuilder.Property(e => e.Country).IsRequired().HasMaxLength(100);
            itemBuilder.Property(e => e.Zipcode).IsRequired();
            itemBuilder.Property(e => e.Time).IsRequired();
            itemBuilder.Property(e => e.PictureURL).IsRequired();
            //Are these necessary? Each is not required
            itemBuilder.Property(e => e.Price);
            itemBuilder.Property(e => e.NumberOfTickets);
            itemBuilder.Property(e => e.PresenterName);


            itemBuilder.HasOne(e => e.CatalogCategory).WithMany().HasForeignKey(e => e.CatalogCategoryID);
            itemBuilder.HasOne(e => e.CatalogType).WithMany().HasForeignKey(e => e.CatalogTypeID);
        }
    }
}
