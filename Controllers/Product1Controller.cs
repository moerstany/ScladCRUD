using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ScladCRUD.Models;

namespace ScladCRUD.Controllers
{
    public class Product1Controller : Controller
    {
        private readonly ScladContext _context;
        public Product1Controller(ScladContext context)
        {
            _context = context;
        }
        // GET: Product1Controller
        public ActionResult Index()
        {
            List<Product1> products;
            products = _context.Product1.ToList();
            return View(products);
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
            Product1 product = new Product1();

            return View(product);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product1 product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            Product1 product = _context.Product1.Find(id);
            return View(product);
        }

        // POST: FacturaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product1 product)
        {
            try
            {
                Product1 pr = _context.Product1.Find(product.IdProduct);
                pr.IdProduct = product.IdProduct;
                pr.ProductName = product.ProductName;
                pr.Articul = product.Articul;
                pr.Cost = product.Cost;
                pr.ProductPic = product.ProductPic;
                pr.Margin = product.Margin;
                _context.SaveChanges();
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
            _context.Product1.Remove(_context.Product1.Find(id));
            _context.SaveChanges();
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