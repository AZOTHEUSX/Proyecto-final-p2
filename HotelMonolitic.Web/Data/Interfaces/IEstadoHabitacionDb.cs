using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using System;

public interface IEstadoHabitacionDb
{
	void SaveEstadoHabitacion(EstadoHabitacionSaveModel estadoHabitacionSave);
	void UpdateEstadoHabitacion(EstadoHabitacionUpdateModel estadoHabitacionUpdate);
	void RemoveEstadoHabitacion(EstadoHabitacionRemoveModel estadoHabitacionRemove);

	List<EstadoHabitacionBaseModel> GetEstadoHabitacion();

	EstadoHabitacionBaseModel GetEstadoHabitacion(int IdEstadoHabitacion);

}
