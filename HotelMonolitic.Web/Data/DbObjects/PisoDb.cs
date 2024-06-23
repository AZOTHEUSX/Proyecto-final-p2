using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Exceptions;
using HotelMonolitic.Web.Data.Models;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class PisoDb : IPiso
    {
        private readonly HotelContext context;
        public PisoDb(HotelContext context)
        {
            this.context = context;
        }
        public List<PisoGetModel> pisoGetModels()
        {
            return this.context.Piso
                .Select(p => new PisoGetModel
                {
                    IdPiso = p.IdPiso,
                    Descripcion = p.Descripcion,
                })
                .ToList(); 
        }
        public PisoGetModel pisoGetModels(int IdPiso) 
        {
            var piso = this.context.Piso.Find(IdPiso);
            if (piso == null) 
            {
                throw new ExceptionDb($"No se encontro el piso con el id {IdPiso}");
            }
            PisoGetModel pisoGetModel = new PisoGetModel()
            {
                IdPiso = piso.IdPiso, 
               
                Descripcion = piso.Descripcion

            };
            return pisoGetModel;
        }
        public void SavePiso(PisoSaveModel pisoSave) 
        {  
            Piso piso = new Piso()
            {
                Descripcion = pisoSave.Descripcion,
            };
            this.context.Piso.Add(piso);
            this.context.SaveChanges();

        }
        public void UpdatePiso(PisoUpdateModel pisoUpdate)
        {
            var pisotoUpdate = this.context.Piso.Find(pisoUpdate.IdPiso);
            pisotoUpdate.Descripcion = pisoUpdate.Descripcion;
            this.context.Piso.Update(pisotoUpdate);
            this.context.SaveChanges();
        }
        public void DeletePiso(PisoDeleteModel pisoDelete)
        {
            var pisotodelete = this.context.Piso.Find(pisoDelete.IdPiso);
            if (pisotodelete is null)
            {
                throw new ExceptionDb("El piso fue borrado");
            }
            //pisotodelete.Deleted = pisoDelete.Deleted;
            //pisotodelete.DeletedDate = pisoDelete.DeletedDate;
            //pisotodelete.UserDeleted = pisoDelete.UserDeleted;
            this.context.Piso.Update(pisotodelete);
            this.context.SaveChanges();
        }
    }
}
