namespace HotelMonolitic.Web.Data.Models
{
    public class RecepcionModel : IRecepcion
    {
        public int RecepcionId { get; set; }
        public int ClienteId { get; set; }
        public int HabitacionId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
