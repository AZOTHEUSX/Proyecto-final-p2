namespace HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD
{
    public class EstadoHabitacionRemoveModel
    {
        public int IdEstadoHabitacion {  get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted {  get; set; }
    }
}
