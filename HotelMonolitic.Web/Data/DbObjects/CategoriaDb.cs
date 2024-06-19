using HotelMonolitic.Web.Data.Context;
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

            CategoriaGetModel categoriaModel = new CategoriaGetModel() 
            {
                // Pendiente continuar desarrollando...
            };
        }
    }
}
