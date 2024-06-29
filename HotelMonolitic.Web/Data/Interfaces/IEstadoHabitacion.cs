using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;


namespace HotelMonolitic.Web.Data.Interfaces
{
    public interface IEstadoHabitacion 
    {
        List<EstadoHabitacionGetModel> GetEstadoHabitacion();
        EstadoHabitacionGetModel GetEstadoHabitacion(int IdEstadoHabitacion);
        void SaveEstadoHabitacion(EstadoHabitacionSaveModel estadoHabitacionSave);
        void UpdateEstadoHabitacion(EstadoHabitacionUpdateModel estadoHabitacionUpdate);
        void RemoveEstadoHabitacion(EstadoHabitacionRemoveModel estadoHabitacionRemove);

    }
}
