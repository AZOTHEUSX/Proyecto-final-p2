namespace HotelMonolitic.Web.Data.Models
{
    public class RecepcionDeleteModel 
    {
        public int IdRecepcion { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime?  DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
