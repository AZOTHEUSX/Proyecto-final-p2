namespace HotelMonolitic.Web.Data.Models
{
    public class UsuarioModel : IUsuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int RolUsuarioId { get; set; }
    }
}
