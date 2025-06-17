using Microsoft.EntityFrameworkCore;
using PlantTrackerApp.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add EF Core with LocalDB connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
