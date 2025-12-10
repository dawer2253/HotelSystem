using HotelSystem.Models;

namespace HotelSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HotelContext context)
        {
            context.Database.EnsureCreated(); // tworzy bazę, jeśli nie istnieje

            if (context.Rooms.Any()) return; // jeśli już są dane, nic nie robimy

            // Seed danych testowych
            context.RoomTypes.AddRange(
                new RoomType { Name = "Single", Beds = 1, PricePerNight = 100 },
                new RoomType { Name = "Double", Beds = 2, PricePerNight = 150 },
                new RoomType { Name = "Suite", Beds = 3, PricePerNight = 300 }
            );

            context.Rooms.AddRange(
                new Room { Number = "101", RoomTypeId = 1 },
                new Room { Number = "102", RoomTypeId = 2 },
                new Room { Number = "201", RoomTypeId = 3 }
            );

            context.Guests.Add(new Guest { Name = "Test Guest", Email = "test@example.com" });

            context.Users.Add(new User { Username = "admin", Password = "admin", IsAdmin = true });

            context.SaveChanges(); // zapis do bazy
        }
    }
}
