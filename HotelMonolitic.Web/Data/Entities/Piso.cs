using HotelMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Piso : BaseEntity
    {
        [Key] public int IdPiso { get; set; }
        public string Descripcion { get; set; }
        //public DateTime ChangeDate { get; internal set; }

    }
}
