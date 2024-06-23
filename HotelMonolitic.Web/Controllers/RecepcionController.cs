using HotelMonolitic.Web.Data.DbObjects;
using HotelMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelMonolitic.Web.Controllers
{
    public class RecepcionController : Controller
    {
        private readonly IRecepcion recepcionDb;
        public RecepcionController(IRecepcion recepcionDb)
        {
            this.recepcionDb = recepcionDb;
        }
        // GET: Recepcion
        public ActionResult Index()
        {
            var recepcion = this.recepcionDb.recepcionGetModels();
            return View(recepcion);
        }

        // GET: Recepcion/Details/5
        public ActionResult Details(int id)
        {
            var recepcion = this.recepcionDb.recepcionGetModels(id);
            return View(recepcion);
        }

        // GET: Recepcion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recepcion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecepcionSaveModel recepcionSaveModel)
        {
            try
            {
                this.recepcionDb.SaveRecepcion(recepcionSaveModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exe)
            {
                var innerException = exe.InnerException != null ? exe.InnerException.Message : string.Empty;
                ModelState.AddModelError(string.Empty, $"Error al guardar : {innerException}");
                return View();
            }
        }

        // GET: Recepcion/Edit/5
        public ActionResult Edit(int id)
        {
            var recepcion = this.recepcionDb.recepcionGetModels(id);
            return View();
        }

        // POST: Recepcion/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RecepcionUpdateModel recepcionUpdateModel)
        {
            try
            {
                this.recepcionDb.UpdateRecepcion(recepcionUpdateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Recepcion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recepcion/Delete/5
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
