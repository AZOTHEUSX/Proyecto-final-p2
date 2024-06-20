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
                throw new CategoriaDBException($"No se encontró la categoría con el id { idCategoria }");
            }

            CategoriaGetModel categoriaModel = new CategoriaGetModel() 
            {
                IdCategoria = categoria.IdCategoria,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                FechaCreacion = categoria.FechaCreacion,
            };
        }

        public void SaveCategoria(CategoriaSaveModel categoriaSave)
        {
            Categoria categoria = new Categoria()
            {
                IdCategoria = categoriaSave.IdCategoria,
                Descripcion = categoriaSave.Descripcion,
                Estado = (bool)categoriaSave.CambiarEstado,
                FechaCreacion = (DateTime)categoriaSave.CambiarFechaCreacion
            };

            this.context.Categoria.Add(categoria);
            this.context.SaveChanges();
        }

        //public void UpdateCategoria(CategoriaUpdateModel categoriaUpdate)
        //{
        //    Categoria categoriaToUpdate = this.context.Categoria.Find(updateModel);

        // Continuar desarrollando...

        //};
    }
}
