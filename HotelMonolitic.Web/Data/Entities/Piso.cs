using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Piso : BaseEntity 
    {
        public int IdPiso { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
