using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Habitacion : BaseEntity
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public string Detalle { get; set; }
        public int Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { set; get; }

    }
}
