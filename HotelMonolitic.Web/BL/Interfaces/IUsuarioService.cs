using HotelMonolitic.Web.BL.Core;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;
using System;

public interface IUsuarioService
{
    ServiceResult GetUsuarios();
    ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioUpdate);
    ServiceResult RemoveUsuario(UsuarioRemoveModel usuarioRemove);
    ServiceResult SaveUsuario(UsuarioSaveModel usuarioSave);
    ServiceResult GetUsuario(int id);
}
