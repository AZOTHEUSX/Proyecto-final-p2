namespace HotelMonolitic.Web.BL.Core
{
    public class ServiceResult
    {
        public ServiceResult() {
            this.Success = true;
        }
        public bool Success { get; set; }
        public string? Mensaje { get; set; }
        public dynamic? Data { get; set; }
    }
}
