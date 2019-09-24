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
                    Information = "Come join us at the gym for a free trial boxing class",
                    Name = "Boxing Class",
                    AddressLineOne = "100 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode=98001,
                    Time="10/18/2019 4:00 P.M. - 5:00 P.M.", PictureURL = "http://externalcatalogbaseurltobereplaced/api/pic/1"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=1, 
                    Information = "Remember that famous soccer player? She will be here! Come get autographs",
                    Name = "Famous Soccer Player At Mall",
                    AddressLineOne = "200", City= "Bellevue", State = "WA", Country = "USA", Zipcode =98002,
                    Time = "12/05/2019 8:00 A.M - 8:00 P.M.", PictureURL = "http://externalcatalogbaseurltobereplaced/api/pic/2"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=1,
                    Information = "Meet to play intramural volleyball at the community center",
                    Name = "Volleyball - All Welcome",
                    AddressLineOne = "300", City= "Seattle", State = "WA", Country = "USA", Zipcode =98003,
                    Time ="1/20/2020 4:00 P.M. - 7:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/3"},
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=2,
                    Information = "Learn the basics of taking photos",
                    Name = "Photograph 101",
                    AddressLineOne = "400 Main Street", City= "Redmond", State = "WA", Country = "USA", Zipcode =98004,
                    Time = "2/25/2020 8:00 A.M. 12:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/4"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=2,
                    Information = "Come get an autograph from that awesome actress you love!",
                    Name = "Famous Actress!",
                    AddressLineOne = "500 Main Street", City= "Lynnwood", State = "WA", Country = "USA", Zipcode =98005,
                    Time = "9/20/2019 2:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/5"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=2,
                    Information = "Calling all jugglers! Meeting and practice group.",
                    Name = "Juggling Juggling",
                    AddressLineOne = "600 Main Street", City= "Tacoma", State = "WA", Country = "USA", Zipcode =98006,
                    Time = "Thursdays 8:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/6"},
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=3,
                    Information = "Join us to learn C# on C# day",
                    Name = "Learn C#",
                    AddressLineOne = "700 Main Street", City= "Shoreline", State = "WA", Country = "USA", Zipcode =98007,
                    Time = "11/28.2019 9:00 A.M. - 5:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/7"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=3,
                    Information = "That astronaut is coming to town!",
                    Name = "See famous astronaut",
                    AddressLineOne = "800 Main Street", City= "Edmonds", State = "WA", Country = "USA", Zipcode =98008,
                    Time = "12/29/2019 6:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/8"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=3,
                    Information = "Meet with other women in tech as we try to make the world a better place",
                    Name = "Women in Tech Meeting",
                    AddressLineOne = "900 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode =98009,
                    Time ="Tuesdays 7:00 P.M. - 8:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/9"},
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=1,
                    Information = "Meet at the park for yoga",
                    Name = "Yoga class",
                    AddressLineOne = "1000 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode=98010,
                    Time="11/02/2019 12:00 P.M. - 1:30 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/10"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=1,
                    Information = "Meet that guy who does things on the mariners!",
                    Name = "Come meet guy from the mariners",
                    AddressLineOne = "1100 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode=98011,
                    Time ="11/28/2019 2:00 P.M. - 6:00 P.M." , PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/11"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=1,
                    Information = "Talk about the joys of raquetball",
                    Name = "Raquetball Discussion Group",
                    AddressLineOne = "1200 Main Street", City= "Cle Elum", State = "WA", Country = "USA", Zipcode =98012,
                    Time ="Every Monday 2:00 P.M. 3:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/12"},
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=2,
                    Information = "Learn in depth videography concepts",
                    Name = "Advanced Videography",
                    AddressLineOne = "1300 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode =98013,
                    Time = "12/06/2019 9:00 A.M. - 1:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/13"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=2,
                    Information = "Win a chance to meet amazing director",
                    Name = "Director coming to town",
                    AddressLineOne = "1400 Main Street", City= "Bellevue", State = "WA", Country = "USA", Zipcode =98014,
                    Time = "05/18/2020 6:00 P.M. - 8:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/14"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=2,
                    Information = "Come audition for secretive movie being call Zoomaster for now",
                    Name = "Movie Audition",
                    AddressLineOne = "1500 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode =98015,
                    Time = "9/21/2019 6:30 A.M. - 4:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/15"},
                new CatalogItem() {CatalogTypeID=1, CatalogCategoryID=3,
                    Information = "Join us for an intro to SQL",
                    Name = "Learn SQL",
                    AddressLineOne = "1600 Main Street", City= "Redmond", State = "WA", Country = "USA", Zipcode =98016,
                    Time = "11/07/2019 8:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/16"},
                new CatalogItem() {CatalogTypeID=2, CatalogCategoryID=3,
                    Information = "Get an autograph on your favorite device made by that guy",
                    Name = "Signings from that tech guy",
                    AddressLineOne = "1700 Main Street", City= "Seattle", State = "WA", Country = "US", Zipcode =98017,
                    Time = "11/13/2019 5:00 P.M. - 6:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/17"},
                new CatalogItem() {CatalogTypeID=3, CatalogCategoryID=3,
                    Information = "Meet with other fellow chemists in the area",
                    Name = "Local Chemists meeting",
                    AddressLineOne = "1800 Main Street", City= "Seattle", State = "WA", Country = "USA", Zipcode =98018,
                    Time = "9/18/2019 2:30 P.M. - 3:30 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/18"},
            };
        }
    }
}
