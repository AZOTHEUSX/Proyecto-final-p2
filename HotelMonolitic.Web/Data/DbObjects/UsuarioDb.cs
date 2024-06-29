using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class UsuarioDb : IUsuario
    {
        private readonly HotelContext context;
        public UsuarioDb(HotelContext context)
        {
            this.context = context;
        }

        public List<UsuarioModel> GetUsuarios()
        {
            return this.context.Usuarios.Select(usuario => DatosUsuario(usuario)).ToList();
        }

        public UsuarioModel GetUsuario(int idUsuario)
        {
            var usuario = this.context.Usuarios.Find(idUsuario);

            return DatosUsuario(usuario);
        }

        public void RemoveUsuario(UsuarioRemoveModel usuarioDelete)
        {
            var usuario = GuardarDtsUsuario(usuarioDelete);
            this.context.Usuarios.Remove(usuario);
            this.context.SaveChanges();
        }

        public void SaveUsuario(UsuarioSaveModel usuarioAdd)
        {
            var usuario = GuardarDtsUsuario(usuarioAdd);
            this.context.Usuarios.Add(usuario);
            this.context.SaveChanges();
        }


        public void UpdateUsuario(UsuarioUpdateModel usuarioUpdate)
        {
            var usuario = GuardarDtsUsuario(usuarioUpdate);
            this.context.Usuarios.Update(usuario);
            this.context.SaveChanges();
        }

        private UsuarioModel DatosUsuario(Usuario dtsUsuario)
        {
            return new UsuarioModel()
            {
                NombreCompleto = dtsUsuario.NombreCompleto,
                Correo = dtsUsuario.Correo,
                IdRolUsuario = dtsUsuario.IdRolUsuario,
                UsuarioId = dtsUsuario.UsuarioId,
                Estado = dtsUsuario.Estado
            };
        }

        private UsuarioSaveModel GuardarDtsUsuario(Usuario dtsUsuario)
        {
            var usuario = (UsuarioSaveModel)DatosUsuario(dtsUsuario);
            usuario.Clave = dtsUsuario.Clave;
            usuario.FechaCreacion = DateTime.Now;

            return usuario;
        }
    }
}
