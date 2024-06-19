using HotelMonolitic.Web.Data.Models.HabitacionCRUD;
using System;


public interface IHabitacionDB
{
	void SaveHabitacion(HabitacionSaveModel habitacionSave);
	void UpdateHabitacion(HabitacionUpdateModel habitacionUpdate);
	void RemoveHabitacion(HabitacionRemoveModel habitacionRemove);

	List<HabitacionBaseModel> GetHabitacion();
	HabitacionBaseModel GetHabitacion (int IdHabitacion);
} 
