namespace HotelMonolitic.Web.Data.Models.Usuario_CRUD
{
    public abstract class UsuarioSaveModel : UsuarioBaseModel
    {
        public string? Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
