using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace hotell.web.Models
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Rooms.Any())
            {
                return;   // DB has been seeded
            }

            var rooms = new Room[]
            {
            new Room{Floor = 1,RoomNumber =  101,RoomName = "101"},
            new Room{Floor = 1,RoomNumber =  102,RoomName = "102"},
            new Room{Floor = 1,RoomNumber =  103,RoomName = "103"},
            new Room{Floor = 1,RoomNumber =  104,RoomName = "104"},
            new Room{Floor = 1,RoomNumber =  105,RoomName = "105"},
            new Room{Floor = 1,RoomNumber =  106,RoomName = "106"},
            new Room{Floor = 1,RoomNumber =  107,RoomName = "107"},
            new Room{Floor = 1,RoomNumber =  108,RoomName = "108"},
            new Room{Floor = 1,RoomNumber =  109,RoomName = "109"},
            new Room{Floor = 1,RoomNumber =  110,RoomName = "110"},
            new Room{Floor = 1,RoomNumber =  111,RoomName = "111"},
            new Room{Floor = 1,RoomNumber =  112,RoomName = "112"},
            new Room{Floor = 1,RoomNumber =  113,RoomName = "113"},
            new Room{Floor = 1,RoomNumber =  114,RoomName = "114"},

            new Room{Floor =2,RoomNumber =  201,RoomName = "201"},
            new Room{Floor = 2,RoomNumber =  202,RoomName = "202"},
            new Room{Floor = 2,RoomNumber =  203,RoomName = "203"},
            new Room{Floor = 2,RoomNumber =  204,RoomName = "204"},
            new Room{Floor = 2,RoomNumber =  205,RoomName = "205"},
            new Room{Floor = 2,RoomNumber =  206,RoomName = "206"},
            new Room{Floor = 2,RoomNumber =  207,RoomName = "207"},
            new Room{Floor = 2,RoomNumber =  208,RoomName = "208"},
            new Room{Floor = 2,RoomNumber =  209,RoomName = "209"},
            new Room{Floor = 2,RoomNumber =  210,RoomName = "210"},
            new Room{Floor = 2,RoomNumber =  211,RoomName = "211"},
            new Room{Floor = 2,RoomNumber =  212,RoomName = "212"},
            new Room{Floor = 2,RoomNumber =  213,RoomName = "213"},
            new Room{Floor = 2,RoomNumber =  214,RoomName = "214"},

            new Room{Floor = 3,RoomNumber =  301,RoomName = "301"},
            new Room{Floor = 3,RoomNumber =  302,RoomName = "302"},
            new Room{Floor = 3,RoomNumber =  303,RoomName = "303"},
            new Room{Floor = 3,RoomNumber =  304,RoomName = "304"},
            new Room{Floor = 3,RoomNumber =  305,RoomName = "305"},
            new Room{Floor = 3,RoomNumber =  306,RoomName = "306"},
            new Room{Floor = 3,RoomNumber =  307,RoomName = "307"},
            new Room{Floor = 3,RoomNumber =  308,RoomName = "308"},
            new Room{Floor = 3,RoomNumber =  309,RoomName = "309"},
            new Room{Floor = 3,RoomNumber =  310,RoomName = "310"},
            new Room{Floor = 3,RoomNumber =  311,RoomName = "311"},
            new Room{Floor = 3,RoomNumber =  312,RoomName = "312"},
            new Room{Floor = 3,RoomNumber =  313,RoomName = "313"},
            new Room{Floor = 3,RoomNumber =  314,RoomName = "314"},
            };
            foreach (var room in rooms)
            {
                context.Rooms.Add(room);
            }
            
            context.SaveChanges();
        }
    }
}
