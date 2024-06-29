using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using System;

namespace HotelMonolitic.BL.Services
{
	public interface IEstadoHabitacionService 
	{
		List<EstadoHabitacionBaseModel> GetEstadoHabitacion();
	}
}