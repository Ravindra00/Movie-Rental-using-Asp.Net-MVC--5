using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRental.Controllers.api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        //get/api/customer
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        //get/api/customer/1

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }
        //post/api/customer
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer)    ;
            _context.SaveChanges();
            customerDto.Id = customer.Id;
            return Created( new Uri(Request.RequestUri + "/" + customer.Id),customerDto );
        }

        //put/api/customer
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(customerDto, customerInDb);
            _context.SaveChanges();
        }
        //delete/api/customer/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)  
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }
            
    }
}
