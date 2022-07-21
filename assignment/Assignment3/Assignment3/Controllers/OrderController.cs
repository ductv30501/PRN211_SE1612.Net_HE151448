using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()

        {
            List<Order> orders = new List<Order>();
            using (var context = new FStoreContext())
            {
                orders = context.Orders.ToList();
            }
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            Order order = null;
            using (var context = new FStoreContext())
            {
                order = context.Orders.SingleOrDefault(o => o.OrderId == id);
            }
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            List<Member> members = null;

            using (var context = new FStoreContext())
            {
                members = context.Members.ToList();
            }
            ViewBag.members = members;
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            List<Member> members = null;

            

            Order order = null;
            using (var context = new FStoreContext())
            {
                members = context.Members.ToList();
                order = context.Orders.SingleOrDefault(o => o.OrderId == id);
            }

            ViewBag.members = members;
            return View(order);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = null;
            using (var context = new FStoreContext())
            {
                order = context.Orders.SingleOrDefault(o => o.OrderId == id);
            }
            return View(order);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order order)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    List<OrderDetail> ods = context.OrderDetails.Where(od => od.OrderId == order.OrderId).ToList();
                    foreach(OrderDetail od in ods)
                    {
                        context.OrderDetails.Remove(od);
                        context.SaveChanges();
                    }

                    context.Orders.Remove(order);
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
