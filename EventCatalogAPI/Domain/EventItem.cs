using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventItem
    {
        //Necessary Event Information
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string PictureURL { get; set; }

        //Optional Event Information
        public decimal TicketPrice { get; set; }
        public string OrganizerName { get; set; }
        public string VenueName { get; set; }

        //Format might change
        public int NumberOfTickets { get; set; }

        //Connections with Category and Type
        public int EventCategoryId { get; set; }
        public virtual EventCategory CatalogCategory { get; set; }
        public int EventTypeId { get; set; }
        public virtual EventType CatalogType { get; set; }
        public int EventLocationId { get; set; }
        public virtual EventLocation EventLocation { get; set; }


    }
}
