using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;
using HotelMonolitic.Web.Data.Models.Usuario_CRUD;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class UsuarioDb : IUsuario
    {
        private UsuarioModel DatosUsuario(Usuario dtsusuario)
        {
            return new UsuarioModel()
            {
                NombreCompleto = dtsusuario.NombreCompleto,
                Correo = dtsusuario.Correo,
                IdRolUsuario = dtsusuario.IdRolUsuario,
                UsuarioId = dtsusuario.UsuarioId,
                Estado = dtsusuario.Estado
            };
        }

        private UsuarioSaveModel GuardarDatosUsuario(Usuario usuariosv)
        {
            //var usuario = DatosUsuario(usuariosv);
           // usuario.FechaCreacion = DateTime.Now;


        }

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

        public void RemoveUsuario(UsuarioRemoveModel usuario)
        {
            throw new NotImplementedException();
        }

        public void SaveUsuario(UsuarioSaveModel usuarioadd)
        {
            //var usuario = GuardarDatosUsuario(usuarioSaveModel);
            //this.context.Usuarios.Add(usuario);
            //this.context.SaveChanges();
        }

        public void UpdateUsuario(UsuarioUpdateModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
