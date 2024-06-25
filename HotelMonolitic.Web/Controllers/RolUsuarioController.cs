using HotelMonolitic.Web.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelMonolitic.Web.Controllers
{
    public class RolUsuarioController : Controller
    {
        private readonly IRolUsuario rolUsuarioDb;

        public RolUsuarioController(IRolUsuario RolUsuarioDb)
        {
            rolUsuarioDb = RolUsuarioDb;
        }
        // GET: RolUsuarioController
        public ActionResult Index()
        {
            var RolUsuarios = this.rolUsuarioDb.GetRolUsuarios();
            return View(RolUsuarios);
        }

        // GET: RolUsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RolUsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RolUsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolUsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RolUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RolUsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
