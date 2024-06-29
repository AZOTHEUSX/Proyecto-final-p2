using HotelMonolitic.Web.BL.Core;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;
using System;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioService usuarioDb;

    public UsuarioService(IUsuarioService usuarioDb)
    {
        this.usuarioDb = usuarioDb;
    }
    public ServiceResult GetUsuario(int id)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            result.Data = usuarioDb.GetUsuario(id);
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error obteniendo al usuario.";
        }
        return result;
    }

    public ServiceResult GetUsuarios()
    {
        ServiceResult result = new ServiceResult();

        try
        {
            result.Data = usuarioDb.GetUsuarios();
        }
        catch(Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error obteniendo los usuarios.";
        }
        return result;
    }

    public ServiceResult RemoveUsuario(UsuarioRemoveModel usuarioRemove)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (usuarioRemove is null)
            {
                result.Success = false;
                result.Mensaje = "El usuario no puede ser nulo.";
                return result;
            }
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error al remover los datos.";
        }
        return result;
    }

    public ServiceResult SaveUsuario(UsuarioSaveModel usuarioSave)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (usuarioSave is null)
            {
                result.Success = false;
                result.Mensaje = "El usuario no puede ser nulo.";
                return result;
            }

            //Validaciones del campo nombre
            if (string.IsNullOrEmpty(usuarioSave.NombreCompleto))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar el nombre de usuario.";
                return result;
            }
            if (usuarioSave.NombreCompleto.Length > 50)
            {
                result.Success = false;
                result.Mensaje = "El nombre del usuario excede los 50 caracteres.";
                return result;
            }

            //validaciones de correo
            if (string.IsNullOrEmpty(usuarioSave.Correo))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar el correo de usuario.";
                return result;
            }
            if (usuarioSave.NombreCompleto.Length > 50)
            {
                result.Success = false;
                result.Mensaje = "El correo del usuario excede los 50 caracteres.";
                return result;
            }

            //validaciones de la clave
            if (string.IsNullOrEmpty(usuarioSave.Clave))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar la clave de usuario.";
                return result;
            }
            if (usuarioSave.NombreCompleto.Length > 50)
            {
                result.Success = false;
                result.Mensaje = "La clave del usuario excede los 50 caracteres.";
                return result;
            }
            this.usuarioDb.SaveUsuario(usuarioSave);
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error al guardar los datos.";
        }
        return result;
    }

    public ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioUpdate)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (usuarioUpdate is null)
            {
                result.Success = false;
                result.Mensaje = "El usuario no puede ser nulo.";
                return result;
            }
            if (string.IsNullOrEmpty(usuarioUpdate.NombreCompleto))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar el nombre de usuario.";
                return result;
            }
            if (usuarioUpdate.NombreCompleto.Length > 50)
            {
                result.Success = false;
                result.Mensaje = "El nombre del usuario excede los 50 caracteres.";
                return result;
            }
            this.usuarioDb.UpdateUsuario(usuarioUpdate);
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error actualizando los datos.";
        }
        return result;
    }
}
