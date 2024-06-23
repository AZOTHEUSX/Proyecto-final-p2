using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.Entities;
using HotelMonolitic.Web.Data.Models;

namespace HotelMonolitic.Web.Data.DbObjects
{
    public class RecepcionDb : IRecepcion
    {
        private readonly HotelContext context;
        public RecepcionDb(HotelContext context)
        {
            this.context = context;
        }
        public List<RecepcionGetModel> recepcionGetModels()
        {
            return this.context.RECEPCION.Select(x => new RecepcionGetModel 
            {
                IdRecepcion = x.IdRecepcion,
                IdCliente = x.IdCliente,
                IdHabitacion = x.IdHabitacion,
                FechaEntrada = x.FechaEntrada,
                FechaSalida = x.FechaSalida,
                FechaSalidaConfirmacion = x.FechaSalidaConfirmacion,
                PrecioInicial = x.PrecioInicial,
                Adelanto = x.Adelanto,
                PrecioRestante = x.PrecioRestante,
                TotalPagado = x.TotalPagado,
                CostoPenalidad = x.CostoPenalidad,
                Observacion = x.Observacion,
            }).ToList();
        }
        public RecepcionGetModel recepcionGetModels(int IdRecepcion)
        {
            var recepcion = this.context.RECEPCION.Find(IdRecepcion);
            if (recepcion == null) 
            {
                throw new Exception($"No se encontro el piso con el id {IdRecepcion}");
            }
            RecepcionGetModel recepcionGetModel = new RecepcionGetModel() 
            {
                IdRecepcion = recepcion.IdRecepcion,
                IdCliente = recepcion.IdCliente,
                IdHabitacion = recepcion.IdHabitacion,
                FechaEntrada = recepcion.FechaEntrada,
                FechaSalida = recepcion.FechaSalida,
                FechaSalidaConfirmacion = recepcion.FechaSalidaConfirmacion,
                PrecioInicial = recepcion.PrecioInicial,
                Adelanto = recepcion.Adelanto,
                PrecioRestante = recepcion.PrecioRestante,
                TotalPagado = recepcion.TotalPagado,
                CostoPenalidad = recepcion.CostoPenalidad,
                Observacion = recepcion.Observacion,
            };
            return recepcionGetModel;
        }
        public void SaveRecepcion(RecepcionSaveModel recepcionSave)
        {
            Recepcion recepcion = new Recepcion() 
            {
                IdHabitacion = recepcionSave.IdHabitacion,
                FechaEntrada = recepcionSave.FechaEntrada,
                FechaSalida = recepcionSave.FechaSalida,
                FechaSalidaConfirmacion = recepcionSave.FechaSalidaConfirmacion,
                PrecioInicial = recepcionSave.PrecioInicial,
                Adelanto = recepcionSave.Adelanto,
                Observacion = recepcionSave.Observacion,
            };
            this.context.RECEPCION.Add(recepcion);
            this.context.SaveChanges();
        }
        public void UpdateRecepcion(RecepcionUpdateModel recepcionUpdate)
        {
            var recepcionToUpdate = this.context.RECEPCION.Find(recepcionUpdate.IdRecepcion);
            //recepcionToUpdate.ModifyDate = recepcionUpdate.ChangeDate;
            //recepcionToUpdate.Usermod = recepcionUpdate.ChangeUsermod;
            recepcionToUpdate.FechaSalida = recepcionUpdate.FechaSalida;
            recepcionToUpdate.FechaSalidaConfirmacion = recepcionUpdate.FechaSalidaConfirmacion;
            recepcionToUpdate.PrecioRestante = recepcionUpdate.PrecioRestante;
            recepcionToUpdate.TotalPagado = recepcionUpdate.TotalPagado;
            recepcionToUpdate.CostoPenalidad = recepcionUpdate.CostoPenalidad;
            this.context.RECEPCION.Update(recepcionToUpdate);
            this.context.SaveChanges();
        }
        public void DeleteRecepcion(RecepcionDeleteModel recepcionDelete)
        {
            var rececpciontodelete = this.context.RECEPCION.Find(recepcionDelete.IdRecepcion);
            if (rececpciontodelete is null)
            {
                throw new Exception("El piso fue borrado");
            }
            //rececpciontodelete.Deleted = recepcionDelete.Deleted;
            //rececpciontodelete.DeletedDate = recepcionDelete.DeletedDate;
            //rececpciontodelete.UserDeleted = recepcionDelete.UserDeleted;
            this.context.RECEPCION.Update(rececpciontodelete);
            this.context.SaveChanges();
        }


    }
}
