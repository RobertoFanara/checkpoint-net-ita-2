using Microsoft.AspNetCore.Mvc;

namespace net_ita_2_checkpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController
    {
        [HttpGet("All")]
        public async Task<IActionResult> GetAllRoomsAsync()
        {
            throw new NotImplementedException();
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
        public async Task<IActionResult> PostRoomAsync()
        {
            throw new NotImplementedException();
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