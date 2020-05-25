using Microsoft.AspNetCore.Mvc;
using SaintLaw_Wash.Models;
using SaintLaw_Wash.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaintLaw_Wash.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepository _customerRepository = null;
        public CustomerController()
        {
            _customerRepository = new CustomerRepository();
        }
           
        public List<CustomerModel> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public CustomerModel GetCustomer(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public List<CustomerModel> SearchCustomers(string customerName)
        {
            return _customerRepository.SearchCustomer(customerName);
        }
    }
}
