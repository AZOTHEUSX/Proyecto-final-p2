namespace HotelMonolitic.Web.Data.Core
{
    public abstract class BaseEntity

    {
        protected BaseEntity() 
        {
            this.FechaCreacion = DateTime.Now;
            this.Deleted = false;
               
        }

        public int CreationUser { get; set; }
        public DateTime FechaCreacion{ get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? Usermod { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
        public bool Estado { get; set; }

    }
}
