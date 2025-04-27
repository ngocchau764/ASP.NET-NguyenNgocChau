﻿using NguyenThiNgocChau_2122110055.Data;
using NguyenThiNgocChau_2122110055.Model;
using NguyenThiNgocChau_2122110055.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using NguyenThiNgocChau_2122110055.Controllers;
using NguyenThiNgocChau_2122110055.Auth;
using NguyenThiNgocChau_2122110055.Controllers;
using NguyenThiNgocChau_2122110055.Data;
using NguyenThiNgocChau_2122110055.Model;


var builder = WebApplication.CreateBuilder(args);

// Cấu hình JWT từ appsettings.json (nếu bạn chuyển sang dùng sau này)
var jwtSettings = new JwtSettings
{
    SecretKey = "THIS_IS_A_SUPER_SECRET_KEY_1234567890_32",
    Issuer = "NguyenThiNgocChau_2122110055App",
    Audience = "NguyenThiNgocChau_2122110055Users",
    ExpirationMinutes = 60
};

builder.Services.AddSingleton(jwtSettings);
builder.Services.AddScoped<TokenService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var key = Encoding.UTF8.GetBytes(jwtSettings.SecretKey);
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

builder.Services.AddAuthorization();
// Thêm cấu hình CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Cho phép tất cả các origin
              .AllowAnyMethod()  // Cho phép tất cả các phương thức (GET, POST, PUT, DELETE...)
              .AllowAnyHeader();  // Cho phép tất cả các headers
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Thêm JWT Authentication vào Swagger
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Nhập token theo định dạng: Bearer {your token}"
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});


var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Sử dụng CORS middleware trước khi Authentication và Authorization
app.UseCors("AllowAll");
app.UseAuthentication(); // BẮT BUỘC trước Authorization
app.UseAuthorization();

// Endpoint mapping
app.MapControllers();

// Gọi các Map endpoint
app.MapAuthEndpoints();

app.MapBrandEndpoints();

app.MapCategoryEndpoints();

app.MapOrderEndpoints();

app.MapOrderItemEndpoints();

app.MapUserEndpoints();

app.MapProductEndpoints();

app.Run();