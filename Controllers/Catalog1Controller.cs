using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScladCRUD.Controllers
{
    public class Catalog1Controller : Controller
    {
        // GET: Catalog1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Catalog1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catalog1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalog1Controller/Create
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

        // GET: Catalog1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalog1Controller/Edit/5
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

        // GET: Catalog1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalog1Controller/Delete/5
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
