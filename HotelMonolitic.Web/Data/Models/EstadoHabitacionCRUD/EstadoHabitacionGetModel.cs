namespace HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD
{
    public class EstadoHabitacionGetModel
    {
        public int IdEstadoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado {  get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
