namespace HotelMonolitic.Web.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int RolUsuarioId { get; set; }
        public RolUsuario RolUsuario { get; set; }
    }
}
