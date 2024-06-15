using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class EstadoHabitacion : BaseEntity
    {
        public int IdEstadoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; } 
        public DateTime FechaCreacion { get; set; }

    }
}
