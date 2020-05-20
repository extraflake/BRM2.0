using API.Models;
using API.Repositories.Data;
using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class EmployeeService : GeneralService<Employee, EmployeeRepository>
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<EmployeeVM> GetEmployee()
        {
            return _employeeRepository.GetEmployee();
        }
    }
}
