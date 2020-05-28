using API.Models;
using API.Repositories.Data;
using API.ViewModels;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
=======
>>>>>>> 0847ca7bfd7524b3b1abd0e83ea477a95eccefb0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class CustomerService : GeneralService<Customer, CustomerRepository>
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IEnumerable<CustomerVM> GetCustomer()
        {
            return _customerRepository.GetCustomer();
        }
<<<<<<< HEAD

        //public async Task<ActionResult<Customer>> PutCustomer(string Id)
        //{
        //    return await _customerRepository.Get(Id);
        //}
=======
>>>>>>> 0847ca7bfd7524b3b1abd0e83ea477a95eccefb0
    }
}
