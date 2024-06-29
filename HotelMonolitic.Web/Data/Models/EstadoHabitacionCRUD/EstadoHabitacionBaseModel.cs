

namespace HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD
{
    public abstract class EstadoHabitacionBaseModel : ModelBase
    {
        public int IdEstadoHabitacion {  get; set; }    
        public string Descripcion { get; set; }
        public bool Estado {  get; set; }
        
        
    }

    
}
