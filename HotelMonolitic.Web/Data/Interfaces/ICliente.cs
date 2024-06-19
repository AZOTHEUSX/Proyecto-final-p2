using HotelMonolitic.Web.Data.Models.ClienteCRUD;

namespace HotelMonolitic.Web.Data.Interfaces
{
	public interface ICliente
	{
		List<ClienteGetModel> GetClientes();
		void UpdateCliente(ClienteUpdateModel updateModel);
		void SaveCliente(ClienteSaveModel saveModel);
		void RemoveCliente(ClienteRemoveModel removeModel);
		ClienteGetModel GetCliente(int idCliente);
	}
}
