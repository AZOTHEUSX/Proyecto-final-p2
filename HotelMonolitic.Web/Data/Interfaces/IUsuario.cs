using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;
using System;

public interface IUsuario
{
    void SaveUsuario(UsuarioSaveModel usuarioadd);
    void UpdateUsuario(UsuarioUpdateModel usuarioupdate);
    void RemoveUsuario(UsuarioRemoveModel usuarioremove);
    List<UsuarioModel> GetUsuarios();
    UsuarioModel GetUsuario(int idUsuario);
}
