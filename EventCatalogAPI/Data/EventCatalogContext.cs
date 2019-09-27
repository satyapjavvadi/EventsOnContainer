using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventCatalogContext : DbContext
    {
        public EventCatalogContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventItem> EventItems { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventCategory>(ConfigureEventCategory);
            modelBuilder.Entity<EventType>(ConfigureEventType);
            modelBuilder.Entity<EventItem>(ConfigureEventItem);
            modelBuilder.Entity<EventLocation>(ConfigureEventLocation);
        }

        private void ConfigureEventCategory(EntityTypeBuilder<EventCategory> builder)
        {
            builder.ToTable("EventCategories");
            builder.Property(c => c.ID).IsRequired().ForSqlServerUseSequenceHiLo("catalog_category_hilo");
            builder.Property(c => c.Category).IsRequired().HasMaxLength(100);
            
        }

        private void ConfigureEventType(EntityTypeBuilder<EventType> builder)
        {
            builder.ToTable("EventTypes");
            builder.Property(t => t.ID).IsRequired().ForSqlServerUseSequenceHiLo("catalog_type_hilo");
            builder.Property(t => t.Type).IsRequired().HasMaxLength(100);
        }

        private void ConfigureEventLocation(EntityTypeBuilder<EventLocation> builder)
        {
            builder.ToTable("EventLocations");
            builder.Property(l => l.Id).IsRequired().ForSqlServerUseSequenceHiLo("event_location_hilo");
            builder.Property(l => l.City).IsRequired().HasMaxLength(100);
            builder.Property(l => l.State).IsRequired().HasMaxLength(100);
        }

        private void ConfigureEventItem(EntityTypeBuilder<EventItem> builder)
        {
            builder.ToTable("EventCatalog");
            builder.Property(c => c.Id).IsRequired().ForSqlServerUseSequenceHiLo("events_hilo");
            builder.Property(c => c.EventName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.EventDescription).IsRequired();
            builder.Property(c => c.AddressLineOne).IsRequired();
            builder.Property(c => c.AddressLineTwo).HasMaxLength(100);
            builder.Property(c => c.Country).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Zipcode).IsRequired();
            builder.Property(c = > c.Date).IsRequired();
            builder.Property(c => c.Time).IsRequired();
            builder.Property(c => c.PictureURL).IsRequired();
            //Are these necessary? Each is not required
            builder.Property(c => c.TicketPrice);
            builder.Property(c => c.NumberOfTickets);
            builder.Property(c => c.OrganizerName);
            builder.Property(c => c.VenueName).IsRequired().HasMaxLength(100);


            builder.HasOne(e => e.CatalogCategory).WithMany().HasForeignKey(e => e.EventCategoryId);
            builder.HasOne(e => e.CatalogType).WithMany().HasForeignKey(e => e.EventTypeId);
        }
    }
}
