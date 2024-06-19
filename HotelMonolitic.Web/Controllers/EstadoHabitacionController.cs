using HotelMonolitic.Web.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HotelMonolitic.Web.Controllers
{
    public class EstadoHabitacionController : Controller
    {
        private readonly HotelContext context;
        
        public EstadoHabitacionController(HotelContext context)
        {
            this.context =context;
        }

        
        // GET: EstadoHabitacionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EstadoHabitacionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadoHabitacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoHabitacionController/Create
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

        // GET: EstadoHabitacionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadoHabitacionController/Edit/5
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

        // GET: EstadoHabitacionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoHabitacionController/Delete/5
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
