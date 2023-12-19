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

        public Task CreateRoomAsync(CreateRoomDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<RoomListDTO>> GetAllRoomsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<RoomListDTO>> GetAvailableRoomsAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<RoomDetailDTO> GetRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoomAsync(UpdateRoomDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}