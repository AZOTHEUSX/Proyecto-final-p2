using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
//builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IEstadoHabitacion, EstadoHabitacionDb>();

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
