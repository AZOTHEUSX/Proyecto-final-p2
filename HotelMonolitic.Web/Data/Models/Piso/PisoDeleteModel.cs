namespace HotelMonolitic.Web.Data.Models
{
    public class PisoDeleteModel 
    {
        public int IdPiso { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
