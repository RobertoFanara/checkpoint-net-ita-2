using net_ita_2_checkpoint.Entities;

namespace net_ita_2_checkpoint.Context
{
    public class DbContext : IDbContext
    {
        public List<Room> Rooms { get; set; } = new();
        public List<Reservation> Reservations { get; set; } = new();
    }
}