using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspmvc.ViewModels;
using aspmvc.Models;
using System.Data.Entity;

namespace aspmvc.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        private ApplicationDbContext _Context;

        public CustomersController()
        {
            _Context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }
        public ViewResult Index()
        {
            var customer = _Context.Customers.Include(c => c.MembershipType).ToList();

            return View(customer);
        }

       

        
        public ActionResult Details(int ID)
        {

            var detail = _Context.Customers.Include(c => c.MembershipType).SingleOrDefault(d => d.Id == ID);

            if (detail == null)
                return HttpNotFound();

            return View(detail);
        }

       
   

    }
}