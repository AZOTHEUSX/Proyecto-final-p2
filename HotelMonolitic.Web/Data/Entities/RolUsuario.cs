using HotelMonolitic.Web.Data.Core;

namespace HotelMonolitic.Web.Data.Entities
{
    public class RolUsuario : BaseEntity
    {        
        public int IdRolUsuario { get; set; }
        public string Descripcion { get; set; }
        
    }
}
