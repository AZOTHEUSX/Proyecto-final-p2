using HotelMonolitic.Web.Data.Models.CategoriaCRUD;

namespace HotelMonolitic.Web.Data.Interfaces
{
	public interface ICategoria
	{
        CategoriaGetModel GetCategoria(int idCategoria);
        List<CategoriaGetModel> GetCategorias();
		void UpdateCategoria(CategoriaUpdateModel updateModel);
		void SaveCategoria(CategoriaSaveModel saveModel);
		void RemoveCategoria(CategoriaRemoveModel removeModel);
	}
}
