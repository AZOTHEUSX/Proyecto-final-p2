using HotelMonolitic.Web.Data.Models.ClienteCRUD;

namespace HotelMonolitic.Web.Data.Interfaces
{
	public interface ICliente
	{
        ClienteGetModel GetCliente(int idCliente);
        List<ClienteGetModel> GetClientes();
		void UpdateCliente(ClienteUpdateModel updateModel);
		void SaveCliente(ClienteSaveModel saveModel);
		void RemoveCliente(ClienteRemoveModel removeModel);
	}
}
