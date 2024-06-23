using HotelMonolitic.Web.Data.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMonolitic.Web.Data.Entities
{
    public class Recepcion : BaseEntity
    {
        [Key] public int IdRecepcion { get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime? FechaSalidaConfirmacion { get; set; }
        public int PrecioInicial { get; set; }
        public int Adelanto { get; set; }
        public int PrecioRestante { get; set; }
        public int TotalPagado { get; set; }
        public int CostoPenalidad { get; set; }
        public string? Observacion { get; set; }
        

    }
}
