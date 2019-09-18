using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            context.Database.Migrate();
            if (!context.CatalogCategories.Any())
            {
                context.CatalogCategories.AddRange(GetPreconfiguredCatalogCategories());
                context.SaveChanges();
            }
            if(!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                context.SaveChanges();
            }
            if(!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredCatalogItems());
                context.SaveChanges();
            }
        }

        private static IEnumerable<CatalogCategory> GetPreconfiguredCatalogCategories()
        {
            return new List<CatalogCategory>()
            {
                new CatalogCategory() {Category = "Health and Exercise"},
                new CatalogCategory() {Category = "Film, Media, and Entertainment"},
                new CatalogCategory() {Category = "Science and Tech"}
            };
        }

        private static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() {Type = "Class, Training, or Workshop"},
                new CatalogType() {Type = "Appearance or Signing"},
                new CatalogType() {Type = "Meeting or Networking Event"}
            };
        }

        private static IEnumerable<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=1,
                    Information = "",
                    Name = "Improving Flow in the Ambulatory Setting",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=1,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=1,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=3,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=3,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=3,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=1,
                    Information = "Come learn and laugh with us as Dr. Joel Fuhrman discusses how we can include nutrient-dense whole plant -based foods in our diets.",
                    Name = "Dr. Joel Fuhrman: Plant-Based Nutrition for the Whole Family",
                    AddressLineOne = "1119 8th Avenue", City= "Seattle", State = "WA", Country = "USA", Zipcode=98101,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=1,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=1,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=2,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=3,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=3,
                    Information = "",
                    Name = "",
                    AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=3,
                    Information = "",
                    Name = "", AddressLineOne = "", City= "", State = "", Country = "", Zipcode = ,
                    Time = , PictureURL = "", },
            };
        }
    }
}
