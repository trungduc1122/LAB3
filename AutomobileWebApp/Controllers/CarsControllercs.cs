using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileWebApp.Controllers
{
    public class CarsControllercs : Controller
    {
        // GET: CarsControllercs
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarsControllercs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsControllercs/Create
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

        // GET: CarsControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsControllercs/Edit/5
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

        // GET: CarsControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsControllercs/Delete/5
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
