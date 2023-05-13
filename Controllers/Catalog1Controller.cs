using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScladCRUD.Migrations;
using ScladCRUD.Models;
using ScladCRUD.Models.ViewModel;
using System;
using System.Linq;



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
            ListViewModel lvm = new ListViewModel();
            List<Catalog1> catData = _context.Catalog1.ToList();
            List<Product1> prData = _context.Product1.ToList();
            lvm.products = prData;
            lvm.catalogs = catData;

            if (string.IsNullOrEmpty(searchValue))
            {
                TempData["InfoMessage"] = "Введите значение для поиска";
                return View(lvm);
            }
            else
            {
                if (searchBy.ToLower() == "productname")
                {
                    var searchByProductName = prData.Where(p => p.ProductName.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByProductName);
                }
                else if (searchBy.ToLower() == "articul")
                {
                    var searchByProductArticul = prData.Where(p => p.Articul.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByProductArticul);
                }
                else if (searchBy.ToLower() == "price")
                {
                    var searchByProductPrice = catData.Where(p => p.Price == int.Parse(searchValue));
                    return View(searchByProductPrice);
                }
            }
            return View(lvm);
        }

        // GET: Product1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        [HttpGet]
        public IActionResult Create()
        {
            Catalog1 catalog1 = new Catalog1();

            return View(catalog1);
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

        /* GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            Catalog1 catalog1 = _context.Catalog1.Find(id);
            return View(catalog1);
        }
        /*
        // POST: FacturaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Catalog1 catalog)
        {
            try
            {
                Catalog1 cat = _context.Catalog1.Find(catalog.IdCatalog);
                cat.IdProduct = catalog.IdProduct;
                cat.ProductName = catalog.Product1.ProductName;
                cat.Articul = product.Articul;
                cat.Cost = product.Cost;
                pr.ProductPic = product.ProductPic;
                pr.Margin = product.Margin;
                _context.SaveChanges();
                TempData["AlertMessage"] = "Продукт изменен!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }
        */
        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            _context.Product1.Remove(_context.Product1.Find(id));
            _context.SaveChanges();
            TempData["AlertMessage"] = "Продукт удален!";
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
    

