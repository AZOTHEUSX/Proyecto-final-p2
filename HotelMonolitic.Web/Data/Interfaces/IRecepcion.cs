using HotelMonolitic.Web.Data.Models;
using System;
public interface IRecepcion
{
    List<RecepcionGetModel> recepcionGetModels();
    RecepcionGetModel recepcionGetModels(int IdRecepcion);
    void SaveRecepcion(RecepcionSaveModel recepcionSave);
    void UpdateRecepcion(RecepcionUpdateModel recepcionUpdate);
    void DeleteRecepcion(RecepcionDeleteModel recepcionDelete);
}
