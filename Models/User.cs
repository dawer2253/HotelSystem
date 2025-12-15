namespace HotelSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // na początek plain text
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        public bool IsAdmin { get; set; }
    }
}
