using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HotelMonolitic.Web.Controllers
{
    public class EstadoHabitacionController : Controller
    {
        private readonly IEstadoHabitacionDb EstadoHabitacionServices;
        
        public EstadoHabitacionController(IEstadoHabitacionDb estadoHabitacionDb)
        {
            this.EstadoHabitacionServices = estadoHabitacionDb;

        }

        
        // GET: EstadoHabitacionController
        public ActionResult Index()
        {
            var estadohabitaciones = this.EstadoHabitacionServices.GetEstadoHabitacion();
            return View(estadohabitaciones);
        }

        // GET: EstadoHabitacionController/Details/5
        public ActionResult Details(int id)
        {
            var esthab = this.EstadoHabitacionServices.GetEstadoHabitacion(id);
            return View(esthab);
        }

        // GET: EstadoHabitacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoHabitacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstadoHabitacionSaveModel estadoHabitacionSave)
        {
            try
            {
                estadoHabitacionSave.ChangeDate = DateTime.Now;
                estadoHabitacionSave.ChangeUser = true;
                this.EstadoHabitacionServices.SaveEstadoHabitacion(estadoHabitacionSave);
                return RedirectToAction (nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        // GET: EstadoHabitacionController/Edit/5
        public ActionResult Edit(int id)
        {
            var esthab = this.EstadoHabitacionServices.GetEstadoHabitacion(id);

            return View(esthab);
        }

        // POST: EstadoHabitacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstadoHabitacionUpdateModel estadoHabitacionUpdate)
        {
            try
            {
                this.EstadoHabitacionServices.UpdateEstadoHabitacion(estadoHabitacionUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoHabitacionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoHabitacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstadoHabitacionRemoveModel estadoHabitacionRemove)
        {
            try
            {
                this.EstadoHabitacionServices.RemoveEstadoHabitacion(estadoHabitacionRemove);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
