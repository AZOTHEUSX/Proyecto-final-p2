namespace HotelMonolitic.Web.Data.Models
{
    public class ClienteModel : ICliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
