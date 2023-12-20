using net_ita_2_checkpoint.Context;
using net_ita_2_checkpoint.DTOs;
using net_ita_2_checkpoint.Services.Interfaces;

namespace net_ita_2_checkpoint.Services
{
    public class RoomService : IRoomService
    {
        private readonly IDbContext _db;

        public RoomService(IDbContext db)
        {
            _db = db;
        }

        public async Task CreateRoomAsync(CreateRoomDTO dto)
        {

            _db.Rooms.Add(new Entities.Room {Name = dto.Name, Type = dto.Type, People = dto.People, Price = dto.Price});
        }

        public Task DeleteRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<RoomListDTO>> GetAllRoomsAsync()
        {
            return _db.Rooms.Select(e => new RoomListDTO
            {
                Id = e.Id,
                Name = e.Name,
                Type = e.Type,
                People = e.People,
                Price = e.Price
            }).ToList();
        }

        public Task<ICollection<RoomListDTO>> GetAvailableRoomsAsync(DateTime date)
        {
            _db.Reservations.Where(e => e.Date == date);
        }

        public Task<RoomDetailDTO> GetRoomAsync(Guid id)
        {
            return _db.Rooms.Where(e => e.Id == id).FirstOrDefault();
        }

        public Task UpdateRoomAsync(UpdateRoomDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}