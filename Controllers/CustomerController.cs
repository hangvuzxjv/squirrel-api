using Microsoft.AspNetCore.Mvc;
using SquirrelAPI.Models;

namespace SquirrelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private static List<KhachHang> customers = new List<KhachHang>
        {
            new KhachHang 
            { 
                Id = 1, 
                HoTen = "Nguyễn Văn A", 
                Email = "nguyenvana@example.com", 
                SoDienThoai = "0901234567" 
            },
            new KhachHang 
            { 
                Id = 2, 
                HoTen = "Trần Thị B", 
                Email = "tranthib@example.com", 
                SoDienThoai = "0902345678" 
            },
            new KhachHang 
            { 
                Id = 3, 
                HoTen = "Lê Văn C", 
                Email = "levanc@example.com", 
                SoDienThoai = "0903456789" 
            },
            new KhachHang 
            { 
                Id = 4, 
                HoTen = "Phạm Thị D", 
                Email = "phamthid@example.com", 
                SoDienThoai = "0904567890" 
            },
            new KhachHang 
            { 
                Id = 5, 
                HoTen = "Hoàng Văn E", 
                Email = "hoangvane@example.com", 
                SoDienThoai = "0905678901" 
            }
        };

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(customers);
        }
    }
}
