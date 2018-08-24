using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspmvc.ViewModels;
using aspmvc.Models;

namespace aspmvc.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
       
        
        public ViewResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

       

        
        public ActionResult Details(int ID)
        {

            var detail = GetCustomers().SingleOrDefault(d => d.Id == ID);

            if (detail == null)
                return HttpNotFound();

            return View(detail);
        }

       
        private IEnumerable<Customer> GetCustomers()
        {
            return  new List<Customer>
            {
                new Customer { Id = 1, Name = "Lloyd Windell I. Aguilar" },
                new Customer { Id = 2, Name = "Ann Valerie Llarenas" }
            };

            

            
        }

    }
}