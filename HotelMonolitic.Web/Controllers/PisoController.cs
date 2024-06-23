using HotelMonolitic.Web.Data.Context;
using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelMonolitic.Web.Controllers
{
    public class PisoController : Controller
    {
        private readonly IPiso pisoDb;
        public PisoController(IPiso pisoDb)
        {
            this.pisoDb = pisoDb;
        }
        // GET: PisoController
        public ActionResult Index()
        {
            var piso = this.pisoDb.pisoGetModels();
            return View(piso);
        }

        // GET: PisoController/Details/5
        public ActionResult Details(int id)
        {   
            var piso = this.pisoDb.pisoGetModels(id);
            return View(piso);
        }

        // GET: PisoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PisoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PisoSaveModel pisoSaveModel)
        {
            try
            {
                this.pisoDb.SavePiso(pisoSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                ModelState.AddModelError(string.Empty, $"Error al guardar el piso: {innerException}");
                return View();
            }
        }

        // GET: PisoController/Edit/5
        public ActionResult Edit(int id)
        {
            var piso = this.pisoDb.pisoGetModels(id);
            return View(piso);
        }

        // POST: PisoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PisoUpdateModel pisoUpdateModel)
        {
            try
            {
                this.pisoDb.UpdatePiso(pisoUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PisoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PisoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
