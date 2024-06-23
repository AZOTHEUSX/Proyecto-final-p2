using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.DbObjects;
using Microsoft.EntityFrameworkCore;
using HotelMonolitic.Web.Data.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HotelContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelContext"));
});
builder.Services.AddScoped<IPiso, PisoDb>();
builder.Services.AddScoped<IRecepcion, RecepcionDb>();

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

