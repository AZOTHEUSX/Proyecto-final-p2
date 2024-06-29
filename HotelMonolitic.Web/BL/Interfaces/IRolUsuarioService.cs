using HotelMonolitic.Web.BL.Core;
using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;
using System;

public interface IRolUsuarioService
{
    ServiceResult GetRolesUsuario();
    ServiceResult UpdateRolUsuario(RolUsuarioUpdateModel rolUsuarioUpdate);
    ServiceResult RemoveRolUsuario(RolUsuarioRemoveModel rolUsuarioRemove);
    ServiceResult SaveRolUsuario(RolUsuarioSaveModel rolUsuarioSave);
    ServiceResult GetRolUsuario(int id);
}
