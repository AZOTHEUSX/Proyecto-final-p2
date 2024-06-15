using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string TipoDocumento  { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
