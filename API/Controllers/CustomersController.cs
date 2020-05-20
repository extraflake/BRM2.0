using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Services.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController<Customer, CustomerService>
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService) : base(customerService)
        {
            _customerService = customerService;
        }
    }
}