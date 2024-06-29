using HotelMonolitic.Web.BL.Core;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Models;
using System;

public class RolUsuarioService : IRolUsuarioService
{
    private readonly IRolUsuarioService rolUsuarioDb;

    public RolUsuarioService(IRolUsuarioService rolUsuarioDb)
    {
        this.rolUsuarioDb = rolUsuarioDb;
    }

    public ServiceResult GetRolesUsuario()
    {
        ServiceResult result = new ServiceResult();
        try
        {
            result.Data = rolUsuarioDb.GetRolesUsuario();
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error obteniendo los roles de los usuarios.";
        }
        return result;
    }

    public ServiceResult GetRolUsuario(int id)
    {
        ServiceResult result = new ServiceResult();
        try
        {
            result.Data = rolUsuarioDb.GetRolUsuario(id);
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error obteniendo el rol de usuarios.";
        }
        return result;
    }

    public ServiceResult RemoveRolUsuario(RolUsuarioRemoveModel rolUsuarioRemove)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (rolUsuarioRemove is null)
            {
                result.Success = false;
                result.Mensaje = "El rol de usuario no puede ser nulo.";
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

    public ServiceResult SaveRolUsuario(RolUsuarioSaveModel rolUsuarioSave)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (rolUsuarioSave is null)
            {
                result.Success = false;
                result.Mensaje = "El rol de usuario no puede ser nulo.";
                return result;
            }
            if (string.IsNullOrEmpty(rolUsuarioSave.Descripcion))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar la descripcion del rol de usuario.";
                return result;
            }

            this.rolUsuarioDb.SaveRolUsuario(rolUsuarioSave);

        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error al guardar los datos.";
        }
        return result;
    }

    public ServiceResult UpdateRolUsuario(RolUsuarioUpdateModel rolUsuarioUpdate)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (rolUsuarioUpdate is null)
            {
                result.Success = false;
                result.Mensaje = "El rol de usuario no puede ser nulo.";
                return result;
            }
            if (string.IsNullOrEmpty(rolUsuarioUpdate.Descripcion))
            {
                result.Success = false;
                result.Mensaje = "Se requiere insertar la descripcion del rol de usuario.";
                return result;
            }
            if (rolUsuarioUpdate.Descripcion.Length > 50)
            {
                result.Success = false;
                result.Mensaje = "La descripcion del rol excede los 50 caracteres.";
                return result;
            }
            this.rolUsuarioDb.UpdateRolUsuario(rolUsuarioUpdate);
        }
        catch (Exception)
        {
            result.Success = false;
            result.Mensaje = "Ocurrio un error actualizando los datos.";
        }
        return result;
    }
}
