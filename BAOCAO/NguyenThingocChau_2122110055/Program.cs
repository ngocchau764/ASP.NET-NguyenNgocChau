using Microsoft.EntityFrameworkCore;
using NguyenThingocChau_2122110055.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
        c.RoutePrefix = string.Empty;  // Đặt trang Swagger làm trang mặc định
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting(); // Đảm bảo middleware này được sử dụng

app.MapControllers();  // Ánh xạ controller

app.Run();
