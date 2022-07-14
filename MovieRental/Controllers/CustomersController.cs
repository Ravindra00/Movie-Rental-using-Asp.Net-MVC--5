using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieRental.DAL;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerRepository customerRepository;

        public CustomersController()
        {
            this.customerRepository = new CustomerRepository(new ApplicationDbContext());
        }
        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public ActionResult Index()
        {
            ViewBag.MembershipTypes = customerRepository.GetMembershipType();
            var customer = customerRepository.GetCustomers();
            return View(customer);
        }

        public ActionResult New()
        {
            ViewBag.MembershipTypes = customerRepository.GetMembershipType();

            return View("CustomerForm");
        }

        [HttpPost]
        public ActionResult Save(CustomerFormViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.MembershipTypes = customerRepository.GetMembershipType();
                return View("CustoemrForm", customer);
            }
            if (customer.Id == 0)
            {
                customerRepository.AddCustomer(customer);
            }
            else
            {
                ViewBag.MembershipTypes = customerRepository.GetMembershipType();
                customerRepository.UpdateCustomer(customer);
            }
            customerRepository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            customerRepository.DeleteCustomer(id);
            customerRepository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var customer = customerRepository.GetCustomerById(id);
            if(customer==null)
                return HttpNotFound();
            ViewBag.MembershipTypes = customerRepository.GetMembershipType();
            return View("CustomerForm",customer);

        }
    }
}