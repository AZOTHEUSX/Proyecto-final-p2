using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using HotelMonolitic.Web.Data.Interfaces;
using HotelMonolitic.BL.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Identity.Client;
using HotelMonolitic.Web.Data.Entities;

using HotelMonolitic.Web.Data.Exceptions;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class EstadoHabitacionDb : IEstadoHabitacion
    {
        private readonly HotelContext context;

        public EstadoHabitacionDb(HotelContext context)
        {
            this.context = context;
        }

        public List<EstadoHabitacionGetModel> GetEstadoHabitacion()
        {
            return this.context.EstadoHabitacion.Select(e => new EstadoHabitacionGetModel
         
            {
                IdEstadoHabitacion = e.IdEstadoHabitacion,
                Descripcion = e.Descripcion,

            })
            .ToList();
        }

        public EstadoHabitacionGetModel GetEstadoHabitacion(int IdEstadoHabitacion)
        {
            var esthab = this.context.EstadoHabitacion.Find(IdEstadoHabitacion);
            
            if (esthab == null)
            {
                throw new ExceptionDb($"El Id EstadoHabitacion no se ecuentra{IdEstadoHabitacion}");

            }

            EstadoHabitacionGetModel estadoHabitacionGetModel = new EstadoHabitacionGetModel()
            {
                IdEstadoHabitacion = esthab.IdEstadoHabitacion,
                Descripcion = esthab.Descripcion,

            };

            return estadoHabitacionGetModel;
        }

        public void SaveEstadoHabitacion(EstadoHabitacionSaveModel estadoHabitacionSave)
        {
            EstadoHabitacion esthab = new EstadoHabitacion()
            {
                Descripcion = estadoHabitacionSave.Descripcion,

            };

            this.context.Add(esthab);
            this.context.SaveChanges();

        }

        public void UpdateEstadoHabitacion(EstadoHabitacionUpdateModel estadoHabitacionUpdate)
        {
            var estadoHabitacionToUpdate = this.context.EstadoHabitacion.Find(estadoHabitacionUpdate.IdEstadoHabitacion);
            
            estadoHabitacionToUpdate.IdEstadoHabitacion = estadoHabitacionUpdate.IdEstadoHabitacion;
            
            this.context.Update(estadoHabitacionToUpdate);
            this.context.SaveChanges();

        }





        public void RemoveEstadoHabitacion(EstadoHabitacionRemoveModel estadoHabitacionRemove)
        {
            var estadoHabitacionToRemove = this.context.EstadoHabitacion.Find(estadoHabitacionRemove);
            
            if (estadoHabitacionToRemove == null)
            {
                throw new ExceptionDb($"El EstadoHabitacion fue borrado");


            }

        }
    }  

   
}
           

