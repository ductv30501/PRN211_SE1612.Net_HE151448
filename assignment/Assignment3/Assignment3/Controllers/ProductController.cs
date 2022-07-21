using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            using (var context = new FStoreContext())
            {
                products = context.Products.ToList();
            }
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            Product product = null;
            using (var context = new FStoreContext())
            {
                product = context.Products.SingleOrDefault(pro => pro.ProductId == id);
            }

            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
               
                using (var context = new FStoreContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = null;
            using (var context = new FStoreContext())
            {
                product = context.Products.SingleOrDefault(pro => pro.ProductId == id);
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Products.Update(product);
                    context.SaveChanges();
                }
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
            Product product = null;
            using (var context = new FStoreContext())
            {
                product = context.Products.SingleOrDefault(pro => pro.ProductId == id);
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
