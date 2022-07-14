using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.DAL
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerFormViewModel> GetCustomers();

        IEnumerable<MembershipType> GetMembershipType();
        CustomerFormViewModel GetCustomerById(int id);
        void AddCustomer(CustomerFormViewModel customer);
        void UpdateCustomer(CustomerFormViewModel customer);
        void DeleteCustomer(int id);
        void Save();

    }
}