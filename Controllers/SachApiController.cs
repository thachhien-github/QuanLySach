using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Models;

namespace QuanLySach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SachApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SachApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sach>>> GetSachs()
        {
            var sachList = await _context.Sachs.ToListAsync();
            return Ok(sachList);
        }

        // GET: api/SachApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sach>> GetSach(int id)
        {
            var sach = await _context.Sachs.FindAsync(id);

            if (sach == null)
            {
                return NotFound(new { message = $"Không tìm thấy sách với mã {id}" });
            }

            return Ok(sach);
        }

        // POST: api/SachApi
        [HttpPost]
        public async Task<ActionResult<Sach>> PostSach([FromBody] Sach sach)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Ensure Id is 0 for database auto-increment
            sach.Id = 0;

            _context.Sachs.Add(sach);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSach), new { id = sach.Id }, sach);
        }

        // PUT: api/SachApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSach(int id, [FromBody] Sach sach)
        {
            if (id != sach.Id)
            {
                return BadRequest(new { message = "Mã sách không khớp giữa đường dẫn và dữ liệu" });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingSach = await _context.Sachs.AnyAsync(s => s.Id == id);
            if (!existingSach)
            {
                return NotFound(new { message = $"Không tìm thấy sách với mã {id} để cập nhật" });
            }

            _context.Entry(sach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(sach);
        }

        // DELETE: api/SachApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSach(int id)
        {
            var sach = await _context.Sachs.FindAsync(id);
            if (sach == null)
            {
                return NotFound(new { message = $"Không tìm thấy sách với mã {id} để xóa" });
            }

            _context.Sachs.Remove(sach);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Xóa sách thành công", id = id });
        }
    }
}
