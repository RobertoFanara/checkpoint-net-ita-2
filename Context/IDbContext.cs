using net_ita_2_checkpoint.Entities;

namespace net_ita_2_checkpoint.Context
{
    public interface IDbContext
    {
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}