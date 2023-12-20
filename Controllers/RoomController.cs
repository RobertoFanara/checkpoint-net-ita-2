using Microsoft.AspNetCore.Mvc;
using net_ita_2_checkpoint.DTOs;
using net_ita_2_checkpoint.Entities;
using net_ita_2_checkpoint.Services.Interfaces;

namespace net_ita_2_checkpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllRoomsAsync()
        {
            return Ok(await _roomService.GetAllRoomsAsync());
        }

        [HttpGet("Available")]
        public async Task<IActionResult> GetAvailableRoomsAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Detail")]
        public async Task<IActionResult> GetRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> PostRoomAsync([FromBody] CreateRoomDTO roomDTO)
        {
            await _roomService.CreateRoomAsync(roomDTO);

            return Ok(roomDTO);
        }

        [HttpPut]
        public async Task<IActionResult> PutRoomAsync()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}