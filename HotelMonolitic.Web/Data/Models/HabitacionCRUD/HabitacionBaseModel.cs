namespace HotelMonolitic.Web.Data.Models.HabitacionCRUD
{
    public class HabitacionBaseModel : ModelBase
    {
        public int Numero { get; set; }
        public string Detalle { get; set; }
        public int Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; } 
    }
}
