using Microsoft.EntityFrameworkCore;
using HotelMonolitic.Web.Data.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CategoriaModel> Categorias { get; set; }
    public DbSet<ClienteModel> Clientes { get; set; }
    public DbSet<EstadoHabitacionModel> EstadoHabitaciones { get; set; }
    public DbSet<HabitacionModel> Habitaciones { get; set; }
    public DbSet<PisoModel> Pisos { get; set; }
    public DbSet<RecepcionModel> Recepciones { get; set; }
    public DbSet<RolUsuarioModel> RolUsuarios { get; set; }
    public DbSet<UsuarioModel> Usuarios { get; set; }
}