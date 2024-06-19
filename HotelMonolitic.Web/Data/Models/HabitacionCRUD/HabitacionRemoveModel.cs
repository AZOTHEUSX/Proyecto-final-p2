namespace HotelMonolitic.Web.Data.Models.HabitacionCRUD
{
    public class HabitacionRemoveModel
    {
        public int IdHabitacion { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted {  get; set; }
    }
}
