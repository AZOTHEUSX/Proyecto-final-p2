using HotelMonolitic.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using System;

namespace HotelMonolitic.Web.Data.Context
{
    public class HotelContext : DbContext
    {
        #region "Constructor"
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
        #endregion
        #region"Db Sets"
        public DbSet<Piso> Piso { get; set; }
        public DbSet<Recepcion> RECEPCION { get; set; }
        #endregion
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Piso>().ToTable("Piso");
            modelBuilder.Entity<Recepcion>().ToTable("RECEPCION"); 
                                                                     
        }

    }
   
}