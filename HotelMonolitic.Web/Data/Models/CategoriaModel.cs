namespace HotelMonolitic.Web.Data.Models
{
    public class CategoriaModel : ICategoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
