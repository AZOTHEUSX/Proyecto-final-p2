using System;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Recepcion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
