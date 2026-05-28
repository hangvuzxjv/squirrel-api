using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

// Tự động chuyển hướng đường dẫn gốc ("/") thẳng vào API khách hàng
app.MapGet("/", () => Results.Redirect("/api/customer"));

app.Run();
