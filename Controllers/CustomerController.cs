using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using SquirrelAPI.Models;

namespace SquirrelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // Đường dẫn trỏ tới file CSDL SQLite vừa tạo
        private readonly string connectionString = "Data Source=Database/squirrel.db";

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = new List<KhachHang>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, HoTen, Email, SoDienThoai FROM KhachHang";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new KhachHang
                        {
                            Id = reader.GetInt32(0),
                            HoTen = reader.GetString(1),
                            Email = reader.GetString(2),
                            SoDienThoai = reader.GetString(3)
                        });
                    }
                }
            }
            return Ok(customers);
        }
    }
}
