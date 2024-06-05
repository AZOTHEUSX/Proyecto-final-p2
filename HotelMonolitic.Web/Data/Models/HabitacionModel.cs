namespace HotelMonolitic.Web.Data.Models
{
    public class HabitacionModel : IHabitacion
    {
        public int HabitacionId { get; set; }
        public string Numero { get; set; }
        public int PisoId { get; set; }
        public int CategoriaId { get; set; }
        public int EstadoHabitacionId { get; set; }
    }
}
