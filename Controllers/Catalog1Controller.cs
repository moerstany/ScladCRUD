using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScladCRUD.Models;
using ScladCRUD.Models.ViewModel;
using System.Linq.Expressions;

namespace ScladCRUD.Controllers
{
    public class Catalog1Controller : Controller
    {
        private readonly ScladContext _context;
        public Catalog1Controller(ScladContext context)
        {
            _context = context;
        }

        // GET: Catalog1Controller
        public ActionResult Index(string searchBy, string searchValue)

        {
            var data = (from c in _context.Catalog1
                        join p in _context.Product1
                        on c.IdProduct equals p.IdProduct
                        select new ListViewModel
                        {
                            IdCatalog = c.IdCatalog,
                            ProductName= p.ProductName,
                            Articul= p.Articul,
                            Price =(p.Cost * p.Margin)/100,
                            Description=c.Description,
                            ProductPic= p.ProductPic


                        }).ToList();

            if (string.IsNullOrEmpty(searchValue))
            {
                TempData["InfoMessage"] = "Введите значение для поиска";
                return View(data);
            }
            else
            {
                if (searchBy.ToLower() == "productname")
                {
                    var searchByProductName = data.Where(p => p.ProductName.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByProductName);
                }
                else if (searchBy.ToLower() == "articul")
                {
                    var searchByProductArticul = data.Where(p => p.Articul.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByProductArticul);
                }
                else if (searchBy.ToLower() == "price")
                {
                    var searchByProductCost = data.Where(p => p.Price == int.Parse(searchValue));
                    return View(searchByProductCost);
                }
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Catalog1 catalog = new Catalog1();

            return View(catalog);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Catalog1 catalog)
        {
            _context.Add(catalog);
            _context.SaveChanges();
            TempData["AlertMessage"] = "Товар Создан!";
            return RedirectToAction("index");
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            Catalog1 catalog = _context.Catalog1.Find(id);
            return View(catalog);
        }

        // POST: FacturaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Catalog1 catalog)
        {
            try
            {
                Catalog1 pr = _context.Catalog1.Find(catalog.IdCatalog);
                pr.IdCatalog = catalog.IdCatalog;
                pr.Description = catalog.Description;
                _context.SaveChanges();
                TempData["AlertMessage"] = "Товар изменен!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            _context.Catalog1.Remove(_context.Catalog1.Find(id));
            _context.SaveChanges();
            TempData["AlertMessage"] = "Товар удален!";
            return RedirectToAction(nameof(Index));
        }

        // POST: ProductController/Delete/5
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
