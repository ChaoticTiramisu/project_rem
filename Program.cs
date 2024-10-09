using Microsoft.EntityFrameworkCore;
using project_rem.Data;
using project_rem.Models; // Adjust the namespace based on your project

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register the SQLite Database Context (EF Core)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Razor Pages or Controllers if needed (for later use)
builder.Services.AddRazorPages(); // Optional if you are using Razor Pages

var app = builder.Build();

// Map a simple route
app.MapGet("/", () => "Hello World!");

// Map Razor Pages (if using)
app.MapRazorPages(); // Optional if using Razor Pages

app.Run();
