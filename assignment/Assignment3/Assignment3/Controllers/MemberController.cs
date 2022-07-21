using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            List<Member> members = new List<Member>();
            using (var context = new FStoreContext())
            {
                members = context.Members.ToList();
            }

            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            

            Member member = null;
            using (var context = new FStoreContext())
            {
                member = context.Members.First(member => member.MemberId == id);


            }
            
            return View(member);
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Member member = null;
                using (var context = new FStoreContext())
                {
                    member = context.Members.SingleOrDefault(member => member.MemberId == id);

                }
                return View(member);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member updatedMember)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Members.Update(updatedMember);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {

            Member member = null;
            using (var context = new FStoreContext())
            {
                member = context.Members.SingleOrDefault(member => member.MemberId == id);
            }

           
            return View(member);
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Member removedMember)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    List<Order> orders = context.Orders.Where(order => order.MemberId == id).ToList();

                    foreach(Order order in orders)
                    {
                        List<OrderDetail> ods = context.OrderDetails.Where(od => od.OrderId == order.OrderId).ToList();
                        context.OrderDetails.RemoveRange(ods);
                        context.SaveChanges();

                        context.Orders.Remove(order);
                        context.SaveChanges();
                    }

                    removedMember = context.Members.SingleOrDefault(member => member.MemberId == id);
                    context.Members.Remove(removedMember);
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
