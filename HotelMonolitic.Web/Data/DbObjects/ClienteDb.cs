using HotelMonolitic.Web.Data.Interfaces;
using HotelMonolitic.Web.Data.Models.ClienteCRUD;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class ClienteDb : ICliente
    {
        public ClienteGetModel GetCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteGetModel> GetClientes()
        {
            throw new NotImplementedException();
        }

        public void RemoveCliente(ClienteRemoveModel removeModel)
        {
            throw new NotImplementedException();
        }

        public void SaveCliente(ClienteSaveModel saveModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateCliente(ClienteUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
