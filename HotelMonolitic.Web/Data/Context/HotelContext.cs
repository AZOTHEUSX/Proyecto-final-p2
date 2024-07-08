using HotelMonolitic.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace HotelMonolitic.Web.Data.Context
{
    public class HotelContext : DbContext
    {
        #region "Constructor"
        public HotelContext(DbContextOptions<HotelContext> options) :base(options)
        { 
            
        }
        #endregion
        
        
        #region "Db Sets"
      
        public DbSet<EstadoHabitacion> EstadoHabitacion { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadoHabitacion>().ToTable("EstadoHabitacion")
                .HasKey(e => e.IdEstadoHabitacion);
            modelBuilder.Entity<Habitacion>().ToTable("Habitacion")
                .HasKey(e => e.IdHabitacion);
        }
    }
}