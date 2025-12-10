namespace HotelSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // na początek plain text
        public bool IsAdmin { get; set; }
    }
}
