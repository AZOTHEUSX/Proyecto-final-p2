using HotelMonolitic.Web.Data.Models;
using System;

public interface IPiso
{
    List<PisoGetModel> pisoGetModels();
    PisoGetModel pisoGetModels(int IdPiso);
    void SavePiso(PisoSaveModel pisoSave);
    void UpdatePiso(PisoUpdateModel pisoUpdate);
    void DeletePiso(PisoDeleteModel pisoDelete);
}

