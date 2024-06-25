using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;
using System;

public interface IRolUsuario
{
        void SaveRolUsuario(RolUsuarioSaveModel rolUsuarioadd);
        void UpdateRolUsuario(RolUsuarioUpdateModel rolUsuarioupdate);
        void RemoveRolUsuario(RolUsuarioRemoveModel rolUsuarioremove);
        List<RolUsuarioModel> GetRolUsuarios();
        RolUsuarioModel GetRolUsuario(int idRolUsuario);
}
