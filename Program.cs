using Microsoft.EntityFrameworkCore;
using PensionSystem.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//string connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");

//builder.Services.AddDbContext<AppDBConnection>(options =>
//{
//    options.UseSqlServer(connectionString);
//});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

// Enable serving static files from the "wwwroot" folder
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
