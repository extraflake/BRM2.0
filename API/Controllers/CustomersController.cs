using System;
using System.Collections.Generic;
using System.Globalization;
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

        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer()
        {
            var get = _customerService.GetCustomer();
            if (!get.Equals(0))
            {
                return Ok(get);
            }
            return BadRequest();
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<Customer>> EditCustomer(string Id, Employee employee)
        //{
        //    var put = await _customerService.PutCustomer(Id);
        //    if (put == null)
        //    {
        //        return NotFound();
        //    }
        //    var checkput = await _customerService.PutCustomer(put);
        //    if (checkput != null)
        //    {
        //        return Ok("Succesfully Updated Data");
        //    }
        //    return BadRequest("Failed to Updated Data");
        //}
    }
}