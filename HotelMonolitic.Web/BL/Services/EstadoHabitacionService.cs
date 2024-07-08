using HotelMonolitic.Web.Data.Interfaces;
using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using System;

namespace HotelMonolitic.BL.Services
{
    public interface EstadoHabitacionService : IEstadoHabitacion
    {
        List<EstadoHabitacionGetModel> GetEstadoHabitacion();
    }

    public interface IEstadoHabitacionDb
    {
        List<EstadoHabitacionGetModel> GetEstadoHabitacion();
    }

    public class EstadoHabitacionServices
    {
        private readonly IEstadoHabitacionDb estadoHabitacionDb;

        public EstadoHabitacionServices(IEstadoHabitacionDb estadoHabitacionDb)
        {
            this.estadoHabitacionDb = estadoHabitacionDb;
        }

        public List<EstadoHabitacionGetModel> GetestadoHabitacion()
        {
            return this.estadoHabitacionDb.GetEstadoHabitacion();
        }
    }

    public class EstadoHabitacionBaseModel
    {
        // Propiedades de la clase
    }
}