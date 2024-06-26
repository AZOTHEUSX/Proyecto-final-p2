namespace HotelMonolitic.Web.Data.Models
{
    public class UsuarioModel : UsuarioBaseModel
    {

    }
    public abstract class UsuarioBaseModel
    {
        public int UsuarioId { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public int IdRolUsuario { get; set; }
        public bool Estado { get; set; }
    }
}
