using AdminCRUD.Data;
using AdminCRUD.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AdminCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly MyDbContext _context;

        public AdminController(MyDbContext context ) 
        { 
            _context=context;
        }
        [HttpGet("GetDuLieu")]
        public async Task<IActionResult> GetDuLieu()
        {
            var data = await _context.users.ToListAsync();
            return Ok(data);
        }
        [HttpPost("PostDuLieu")]
        public async Task<IActionResult>PostDuLieu([FromForm]UserVM user)
        {
            try
            {
                Users user1 = new Users();
                user1.Name = user.Name;
                user1.Username = user.Username;
                user1.Password = user.Password;
                await _context.users.AddAsync(user1);
                await _context.SaveChangesAsync();
                return Ok("Lưu thành công");

            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteDuLieu")]
        public async Task<IActionResult> DeleteDuLieu(int id)
        {
            try
            {
                var data=await _context.users.FirstOrDefaultAsync(x => x.Id == id); 
                _context.users.Remove(data);
                await _context.SaveChangesAsync();
                return Ok("Xóa thành công");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("PutDuLieu")]
        public async Task<IActionResult>PutDuLieu(int id,[FromForm]UserVM users)
        {
            try
            {
                var data=await _context.users.FirstOrDefaultAsync(e=>e.Id== id);
                data.Name = users.Name;
                data.Username=users.Username;
                data.Password=users.Password;
                await _context.SaveChangesAsync();
                return Ok("Cập nhật thành công");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
