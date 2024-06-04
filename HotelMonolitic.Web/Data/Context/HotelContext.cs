using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace HotelMonolitic.Web.Data.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
 
    #region "Db Sets"
    public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estadohabitacion> EstadoHabitacion { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<Piso> PISO { get; set; }
        public DbSet<Recepcion> RECEPCION { get; set; }
        public DbSet<Roldeusuario> RolUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        #endregion
    }
}
