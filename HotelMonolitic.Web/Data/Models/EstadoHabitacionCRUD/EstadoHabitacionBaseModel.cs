

namespace HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD
{
    public abstract class EstadoHabitacionBaseModel : ModelBase
    {
        public string Descripcion { get; set; }
        public bool Estado {  get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    
}
