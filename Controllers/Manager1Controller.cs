using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScladCRUD.Controllers
{
    public class Manager1Controller : Controller
    {
        // GET: Manager1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Manager1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Manager1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager1Controller/Create
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

        // GET: Manager1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Manager1Controller/Edit/5
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

        // GET: Manager1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manager1Controller/Delete/5
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
