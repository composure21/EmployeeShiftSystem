using EmployeeShiftSystem.Services;
using Microsoft.EntityFrameworkCore;
using EmployeeShiftSystem.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ShiftService>();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
