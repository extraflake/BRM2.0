﻿using API.Models;
using API.Repositories.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

        //public async Task<ActionResult<Customer>> PutCustomer(string Id)
        //{
        //    return await _customerRepository.Get(Id);
        //}
    }
}