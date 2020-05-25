using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using SaintLaw_Wash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaintLaw_Wash.Repository
{
    public class CustomerRepository
    {
        public List<CustomerModel> GetAllCustomers()
        {
            return DataSource();
        }

        public CustomerModel GetCustomerById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<CustomerModel> SearchCustomer(string customerNmae)
        {
            return DataSource().Where(x => x.Name == customerNmae).ToList();
        }

        private List<CustomerModel> DataSource()
        {
            return new List<CustomerModel>()
            {
                new CustomerModel(){Id = 1, Name = "saintlaw"},
                new CustomerModel(){Id = 2, Name = "qbasic"},
                new CustomerModel(){Id = 3, Name = "elkay"},
                new CustomerModel(){Id = 4, Name = "Dammy"},
                new CustomerModel(){Id = 5, Name = "bunmi"},
            };
        }
    }
}
