namespace HotelMonolitic.Web.Data.Entities
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int EstadoHabitacionId { get; set; }
        public EstadoHabitacion EstadoHabitacion { get; set; }
    }
}
