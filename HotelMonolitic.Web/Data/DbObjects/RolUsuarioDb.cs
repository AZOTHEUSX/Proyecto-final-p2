using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;

namespace HotelMonolitic.Web.Data.DbObjects
{

    public class RolUsuarioDb : IRolUsuario
    {
        private RolUsuarioModel DatosRolUsuario(RolUsuario rolusuario)
        {
            return new RolUsuarioModel()
            {
                Descripcion = rolusuario.Descripcion,
                Estado = rolusuario.Estado,
                IdRolUsuario = rolusuario.IdRolUsuario
                
            };
        }
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

        public void RemoveRolUsuario(RolUsuarioRemoveModel rolUsuario)
        {
            throw new NotImplementedException();
        }

        public void SaveRolUsuario(RolUsuarioSaveModel rolUsuario)
        {
            throw new NotImplementedException();
        }

        public void UpdateRolUsuario(RolUsuarioUpdateModel rolUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
