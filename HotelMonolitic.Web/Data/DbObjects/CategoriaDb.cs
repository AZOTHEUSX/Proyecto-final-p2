using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Exceptions;
using HotelMonolitic.Web.Data.Interfaces;
using HotelMonolitic.Web.Data.Models.CategoriaCRUD;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class CategoriaDb : ICategoria
    {
        private readonly HotelContext context;

        public CategoriaDb(HotelContext context)
        {
            this.context = context;
        }

        public CategoriaGetModel GetCategoria(int idCategoria)
        {
            var categoria = this.context.Categoria.Find(idCategoria);

            if (categoria is null)
            {
                throw new CategoriaDBException($"No se encontró la categoría con el id {idCategoria}");
            }

            CategoriaGetModel categoriaModel = new CategoriaGetModel()
            {
                IdCategoria = categoria.IdCategoria,
                Descripcion = categoria.Descripcion,
                CambiarEstado = categoria.CambiarEstado,
                CambiarFechaCreacion = categoria.CambiarFechaCreacion,
            };
        }

        public List<CategoriaGetModel> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public void RemoveCategoria(CategoriaRemoveModel removeModel)
        {
            throw new NotImplementedException();
        }

        public void SaveCategoria(CategoriaSaveModel categoriaSave)
        {
            Categoria categoria = new Categoria()
            {
                IdCategoria = categoriaSave.IdCategoria,
                Descripcion = categoriaSave.Descripcion,
                CambiarEstado = categoriaSave.CambiarEstado,
                CambiarFechaCreacion = categoriaSave.CambiarFechaCreacion
            };

            this.context.Categoria.Add(categoria);
            this.context.SaveChanges();
        }

        public void UpdateCategoria(CategoriaUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
