using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gestión_de_Reservas.Data;
using Gestión_de_Reservas.Models;

namespace Gestión_de_Reservas.Controllers
{
    public class ReservasController1 : Controller
    {
        // GET: ReservasController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservasController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservasController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservasController1/Create
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

        // GET: ReservasController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservasController1/Edit/5
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

        // GET: ReservasController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservasController1/Delete/5
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
