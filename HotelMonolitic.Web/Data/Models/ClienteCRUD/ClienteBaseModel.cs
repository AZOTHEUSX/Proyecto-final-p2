namespace HotelMonolitic.Web.Data.Models.ClienteCRUD
{
    public class ClienteBaseModel : ModelBase
    {
        public string? TipoDocumento { get; set; }
        public string? Documento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo {  get; set; }
    }
}
