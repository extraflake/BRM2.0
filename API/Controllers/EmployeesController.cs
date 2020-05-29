using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Services.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employee, EmployeeService>
    {
        private readonly EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployee")]
        public IActionResult GetEmployee()
        {
            var get = _employeeService.GetEmployee();
            if (!get.Equals(0))
            {
                return Ok(get);
            }
            return BadRequest();
        }

        [HttpGet("GetEmployee/{id}")]
        public Task<IEnumerable<EmployeeRoleVM>> GetEmployeeRoleVMs(int Id)
        {
            var getemployeerole =_employeeService.GetEmployeeRole(Id);
            return getemployeerole;
        }
    }
}