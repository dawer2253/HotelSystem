using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<User> Users { get; set; }


}
