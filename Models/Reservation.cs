namespace HotelSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int GuestId { get; set; }
        public Guest Guest { get; set; }
    }
}
