using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Usuario : BaseEntity
    {
        public int UsuarioId { get; set; }
        public string? NombreCompleto { get; set; }
        public string ?Correo { get; set; }
        public int IdRolUsuario { get; set; }
        public string? Clave { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
