using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Quiz.Any())
            {
                return;   // DB has been seeded
            }

            //var rooms = new Room[]
            //{
            //new Room{Floor = 1,RoomNumber =  101,RoomName = "101"},
            //new Room{Floor = 3,RoomNumber =  314,RoomName = "314"},
            //};
            //foreach (var room in rooms)
            //{
            //    context.Rooms.Add(room);
            //}

            //context.SaveChanges();
        }
    }
}