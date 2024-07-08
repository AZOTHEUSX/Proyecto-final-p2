using HotelMonolitic.BL.Services;
using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HotelContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HotelContext")));
builder.Services.AddScoped<IEstadoHabitacion, EstadoHabitacionDb>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
