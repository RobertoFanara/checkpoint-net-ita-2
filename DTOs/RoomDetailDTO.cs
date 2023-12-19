namespace net_ita_2_checkpoint.DTOs
{
    public class RoomDetailDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int People { get; set; }
        public decimal Price { get; set; }
        public ICollection<RoomReservationDTO> Reservations { get; set; } = new List<RoomReservationDTO>();
    }
}