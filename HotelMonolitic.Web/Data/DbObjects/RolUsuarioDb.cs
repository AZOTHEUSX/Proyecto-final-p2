using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;
using Microsoft.EntityFrameworkCore;

namespace HotelMonolitic.Web.Data.DbObjects
{

    public class RolUsuarioDb : IRolUsuario
    {
        private readonly HotelContext context;
        public RolUsuarioDb(HotelContext context)
        {
            this.context = context;
        }

        public List<RolUsuarioModel> GetRolUsuarios()
        {
            return this.context.RolesUsuario.Select(rolusuario => DatosRolUsuario(rolusuario)).ToList();
        }

        public RolUsuarioModel GetRolUsuario(int idRolUsuario)
        {
            var rolUsuario = this.context.RolesUsuario.Find(idRolUsuario);

            return DatosRolUsuario(rolUsuario);
        }

        public void RemoveRolUsuario(RolUsuarioRemoveModel rolUsuarioDelete)
        {
            var usuario = GuardarDtsUsuario(rolUsuarioDelete);
            this.context.Usuarios.Remove(usuario);
            this.context.SaveChanges();
        }

        public void SaveRolUsuario(RolUsuarioSaveModel rolUsuarioAdd)
        {
            var usuario = GuardarDtsUsuario(rolUsuarioAdd);
            this.context.Usuarios.Add(usuario);
            this.context.SaveChanges();
        }

        public void UpdateRolUsuario(RolUsuarioUpdateModel rolUsuarioUpdate)
        {
            var usuario = DatosRolUsuario(rolUsuarioUpdate);
            this.context.Usuarios.Update(usuario);
            this.context.SaveChanges();
        }

        private RolUsuarioModel DatosRolUsuario(RolUsuario dtsRolUsuario)
        {
            return new RolUsuarioModel()
            {
                IdRolUsuario = dtsRolUsuario.IdRolUsuario,
                Descripcion = dtsRolUsuario.Descripcion,
                Estado = dtsRolUsuario.Estado
            };
        }

        private RolUsuarioSaveModel GuardarDtsUsuario(RolUsuario dtsRolUsuario)
        {
            var rolUsuario = (RolUsuarioSaveModel)DatosRolUsuario(dtsRolUsuario);
            rolUsuario.FechaCreacion = DateTime.Now;
            

            return rolUsuario;
        }
    }
}
