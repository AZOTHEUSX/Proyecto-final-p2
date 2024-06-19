namespace HotelMonolitic.Web.Data.Models.HabitacionCRUD
{
    public class HabitacionGetModel
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public string Detalle { get; set; }
        public int Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
