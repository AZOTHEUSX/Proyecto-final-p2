namespace HotelMonolitic.Web.Data.Models
{
    public class RolUsuarioModel : RolUsuarioBaseModel
    {
    }

    public abstract class RolUsuarioBaseModel
    {
        public int IdRolUsuario { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado {  get; set; }
    }
}
