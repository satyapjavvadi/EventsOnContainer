using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class CatalogItem
    {
        //Necessary Event Information
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
        public string Time { get; set; }
        public string PictureURL { get; set; }

        //Optional Event Information
        public decimal Price { get; set; }
        public string PresenterName { get; set; }

        //Format might change
        public int NumberOfTickets { get; set; }

        //Connections with Category and Type
        public int CatalogCategoryID { get; set; }
        public virtual CatalogCategory CatalogCategory { get; set; }
        public int CatalogTypeID { get; set; }
        public virtual CatalogType CatalogType { get; set; }


    }
}
