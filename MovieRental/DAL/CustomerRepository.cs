using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(CustomerFormViewModel customer)
        {
            Customer customers = new Customer()
            {
                Name = customer.Name,
                IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter,
                Email = customer.Email,
                Phone = customer.Phone,
                Birthdate = customer.Birthdate,
                MembershipTypeId = customer.MembershipTypeId
            };
            _context.Customers.Add(customers);
            Save();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            _context.Customers.Remove(customer);
        }

        public CustomerFormViewModel GetCustomerById(int id)
        {
            var customer = _context.Customers.Find(id);

            CustomerFormViewModel customerview = new CustomerFormViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter,
                Email = customer.Email,
                Phone = customer.Phone,
                Birthdate = customer.Birthdate,
                MembershipTypeId = customer.MembershipTypeId

            };
            return customerview;
        }

        public IEnumerable<CustomerFormViewModel> GetCustomers()
        {

            IEnumerable<CustomerFormViewModel> customerFormViewModels = (from c in _context.Customers
                                                                         select new CustomerFormViewModel
                                                                         {
                                                                             Id = c.Id,
                                                                             Name = c.Name,
                                                                             IsSubscribedToNewsletter = c.IsSubscribedToNewsletter,
                                                                             Birthdate = c.Birthdate,
                                                                             Phone = c.Phone,
                                                                             Email = c.Email,
                                                                             MembershipTypeId = c.MembershipTypeId,
                                                                            MembershipType = c.MembershipType
                                                                        }).ToList();
            return customerFormViewModels;
        }

        public IEnumerable<MembershipType> GetMembershipType()
        {
            return _context.MembershipTypes.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCustomer(CustomerFormViewModel customer)
        {
            var data = _context.Customers.Find(customer.Id);
            if (data != null)
            {
                data.Name = customer.Name;
                data.Phone = customer.Phone;
                data.MembershipTypeId = customer.MembershipTypeId;
                data.Email = customer.Email;
                data.Birthdate = customer.Birthdate;
            }
            _context.SaveChanges();

        }
        public void CustomerConversion()
        {

        }

    }
}