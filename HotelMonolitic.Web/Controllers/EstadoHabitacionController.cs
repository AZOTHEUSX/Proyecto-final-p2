using HotelMonolitic.BL.Services;
using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Interfaces;
using HotelMonolitic.Web.Data.Models.EstadoHabitacionCRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HotelMonolitic.Web.Controllers
{
    public class EstadoHabitacionController : Controller
    {
        private readonly IEstadoHabitacion estadoHabitaciondb;

        

        public EstadoHabitacionController(IEstadoHabitacion estadoHabitaciondb)
        {
            this.estadoHabitaciondb = estadoHabitaciondb;
        }


        //GET: EstadoHabitacionController
        public ActionResult Index()
        {
            var esthab = this.estadoHabitaciondb.GetEstadoHabitacion();
            return View(esthab);
        }

        // GET: EstadoHabitacionController/Details/5
        public ActionResult Details(int id)
        {
            var esthab = this.estadoHabitaciondb.GetEstadoHabitacion(id);
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
                //estadoHabitacionSave.ChangeDate = DateTime.Now;
                //estadoHabitacionSave.ChangeUser = true;
                this.estadoHabitaciondb.SaveEstadoHabitacion(estadoHabitacionSave);
                return RedirectToAction(nameof(Index));
            }

            catch (Exception ex)
            {
                var InnerException = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                ModelState.AddModelError(string.Empty, $"Error al guardar el EstadoHabitacion {InnerException}");
                return View();
            }
        }

        // GET: EstadoHabitacionController/Edit/5
        public ActionResult Edit(int id)
        {
            var esthab = this.estadoHabitaciondb.GetEstadoHabitacion(id);

            return View(esthab);
        }

        // POST: EstadoHabitacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstadoHabitacionUpdateModel estadoHabitacionUpdate)
        {
            try
            {
                this.estadoHabitaciondb.UpdateEstadoHabitacion(estadoHabitacionUpdate);
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
                //this.estadoHabitacionDb.RemoveEstadoHabitacion(estadoHabitacionRemove);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
