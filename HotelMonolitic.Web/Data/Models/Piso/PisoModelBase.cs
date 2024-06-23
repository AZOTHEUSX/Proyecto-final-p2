namespace HotelMonolitic.Web.Data.Models
{
	public abstract class PisoModelBase 
	{
		public int IdPiso { get; set; }
		public string Descripcion { get; set; }
		public bool Estado { get; set; }
	}
}