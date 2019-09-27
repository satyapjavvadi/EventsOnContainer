using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventCatalogSeed
    {
        public static void Seed(EventCatalogContext context)
        {
            context.Database.Migrate();
            if (!context.EventCategories.Any())
            {
                context.EventCategories.AddRange(GetPreconfiguredEventCategories());
                context.SaveChanges();
            }
            if(!context.EventTypes.Any())
            {
                context.EventTypes.AddRange(GetPreconfiguredEventTypes());
                context.SaveChanges();
            }
            if(!context.EventLocations.Any())
            {
                context.EventLocations.AddRange(GetPreconfiguredEventLocations());
                context.SaveChanges();
            }
            if(!context.EventItems.Any())
            {
                context.EventItems.AddRange(GetPreconfiguredEventItems());
                context.SaveChanges();
            }
        }

        private static IEnumerable<EventCategory> GetPreconfiguredEventCategories()
        {
            return new List<EventCategory>()
            {
                new EventCategory() {Category = "Health and Exercise"},
                new EventCategory() {Category = "Film, Media, and Entertainment"},
                new EventCategory() {Category = "Science and Tech"}
            };
        }

        private static IEnumerable<EventType> GetPreconfiguredEventTypes()
        {
            return new List<EventType>()
            {
                new EventType() {Type = "Class, Training, or Workshop"},
                new EventType() {Type = "Appearance or Signing"},
                new EventType() {Type = "Meeting or Networking Event"}
            };
        }

        private static IEnumerable<EventLocation> GetPreconfiguredEventLocations()
        {
            return new List<EventLocation>()
            {
                new EventLocation() {City = "Seattle", State = "WA"},
                new EventLocation() {City = "Boston", State = "MA"}
            };
        }

        private static IEnumerable<EventItem> GetPreconfiguredEventItems()
        {
            return new List<EventItem>()
            {
                new EventItem() {EventTypeId=1, EventCategoryId=1, EventLocationId=1,
                    EventDescription = "Come join us at the gym for a free trial boxing class",
                    EventName = "Boxing Class",
                    AddressLineOne = "100 Main Street", Country = "USA", Zipcode=98001,
                    Time="10/18/2019 4:00 P.M. - 5:00 P.M.", PictureURL = "http://externalcatalogbaseurltobereplaced/api/pic/1"},
                new EventItem() {EventTypeId=2, EventCategoryId=1, EventLocationId=1,
                    EventDescription = "Remember that famous soccer player? She will be here! Come get autographs",
                    EventName = "Famous Soccer Player At Mall",
                    AddressLineOne = "200 Main Street", Country = "USA", Zipcode =98002,
                    Time = "12/05/2019 8:00 A.M - 8:00 P.M.", PictureURL = "http://externalcatalogbaseurltobereplaced/api/pic/2"},
                new EventItem() {EventTypeId=3, EventCategoryId=1, EventLocationId=1,
                    EventDescription = "Meet to play intramural volleyball at the community center",
                    EventName = "Volleyball - All Welcome",
                    AddressLineOne = "300 Main Street", Country = "USA", Zipcode =98003,
                    Time ="1/20/2020 4:00 P.M. - 7:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/3"},
                new EventItem() {EventTypeId=1, EventCategoryId=2, EventLocationId=1,
                    EventDescription = "Learn the basics of taking photos",
                    EventName = "Photograph 101",
                    AddressLineOne = "400 Main Street", Country = "USA", Zipcode =98004,
                    Time = "2/25/2020 8:00 A.M. 12:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/4"},
                new EventItem() {EventTypeId=2, EventCategoryId=2, EventLocationId=1,
                    EventDescription = "Come get an autograph from that awesome actress you love!",
                    EventName = "Famous Actress!",
                    AddressLineOne = "500 Main Street", Country = "USA", Zipcode =98005,
                    Time = "9/20/2019 2:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/5"},
                new EventItem() {EventTypeId=3, EventCategoryId=2, EventLocationId=1,
                    EventDescription = "Calling all jugglers! Meeting and practice group.",
                    EventName = "Juggling Juggling",
                    AddressLineOne = "600 Main Street", Country = "USA", Zipcode =98006,
                    Time = "Thursdays 8:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/6"},
                new EventItem() {EventTypeId=1, EventCategoryId=3, EventLocationId=1,
                    EventDescription = "Join us to learn C# on C# day",
                    EventName = "Learn C#",
                    AddressLineOne = "700 Main Street", City= "Shoreline", State = "WA", Country = "USA", Zipcode =98007,
                    Time = "11/28.2019 9:00 A.M. - 5:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/7"},
                new EventItem() {EventTypeId=2, EventCategoryId=3, EventLocationId=1,
                    EventDescription = "That astronaut is coming to town!",
                    EventName = "See famous astronaut",
                    AddressLineOne = "800 Main Street", Country = "USA", Zipcode =98008,
                    Time = "12/29/2019 6:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/8"},
                new EventItem() {EventTypeId=3, EventCategoryId=3, EventLocationId=1,
                    EventDescription = "Meet with other women in tech as we try to make the world a better place",
                    EventName = "Women in Tech Meeting",
                    AddressLineOne = "900 Main Street", Country = "USA", Zipcode =98009,
                    Time ="Tuesdays 7:00 P.M. - 8:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/9"},
                new EventItem() {EventTypeId=1, EventCategoryId=1, EventLocationId=2,
                    EventDescription = "Meet at the park for yoga",
                    EventName = "Yoga class",
                    AddressLineOne = "1000 Main Street", Country = "USA", Zipcode=98010,
                    Time="11/02/2019 12:00 P.M. - 1:30 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/10"},
                new EventItem() {EventTypeId=2, EventCategoryId=1, EventLocationId=2,
                    EventDescription = "Meet that guy who does things on the mariners!",
                    EventName = "Come meet guy from the mariners",
                    AddressLineOne = "1100 Main Street", Country = "USA", Zipcode=98011,
                    Time ="11/28/2019 2:00 P.M. - 6:00 P.M." , PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/11"},
                new EventItem() {EventTypeId=3, EventCategoryId=1, EventLocationId=2,
                    EventDescription = "Talk about the joys of raquetball",
                    EventName = "Raquetball Discussion Group",
                    AddressLineOne = "1200 Main Street", Country = "USA", Zipcode =98012,
                    Time ="Every Monday 2:00 P.M. 3:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/12"},
                new EventItem() {EventTypeId=1, EventCategoryId=2, EventLocationId=2,
                    EventDescription = "Learn in depth videography concepts",
                    EventName = "Advanced Videography",
                    AddressLineOne = "1300 Main Street", Country = "USA", Zipcode =98013,
                    Time = "12/06/2019 9:00 A.M. - 1:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/13"},
                new EventItem() {EventTypeId=2, EventCategoryId=2, EventLocationId=2,
                    EventDescription = "Win a chance to meet amazing director",
                    EventName = "Director coming to town",
                    AddressLineOne = "1400 Main Street", Country = "USA", Zipcode =98014,
                    Time = "05/18/2020 6:00 P.M. - 8:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/14"},
                new EventItem() {EventTypeId=3, EventCategoryId=2, EventLocationId=2,
                    EventDescription = "Come audition for secretive movie being call Zoomaster for now",
                    EventName = "Movie Audition",
                    AddressLineOne = "1500 Main Street", Country = "USA", Zipcode =98015,
                    Time = "9/21/2019 6:30 A.M. - 4:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/15"},
                new EventItem() {EventTypeId=1, EventCategoryId=3, EventLocationId=2,
                    EventDescription = "Join us for an intro to SQL",
                    EventName = "Learn SQL",
                    AddressLineOne = "1600 Main Street", Country = "USA", Zipcode =98016,
                    Time = "11/07/2019 8:00 P.M. - 9:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/16"},
                new EventItem() {EventTypeId=2, EventCategoryId=3, EventLocationId=2,
                    EventDescription = "Get an autograph on your favorite device made by that guy",
                    EventName = "Signings from that tech guy",
                    AddressLineOne = "1700 Main Street", Country = "US", Zipcode =98017,
                    Time = "11/13/2019 5:00 P.M. - 6:00 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/17"},
                new EventItem() {EventTypeId=3, EventCategoryId=3, EventLocationId=2,
                    EventDescription = "Meet with other fellow chemists in the area",
                    EventName = "Local Chemists meeting",
                    AddressLineOne = "1800 Main Street", Country = "USA", Zipcode =98018,
                    Time = "9/18/2019 2:30 P.M. - 3:30 P.M.", PictureURL ="http://externalcatalogbaseurltobereplaced/api/pic/18"},
            };
        }
    }
}
