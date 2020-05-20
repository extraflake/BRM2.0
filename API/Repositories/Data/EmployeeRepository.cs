using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employee, MyContext>
    {
        IConfiguration _configuration { get; } 

        public EmployeeRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<EmployeeVM> GetEmployee()
        {
            using(var connection = new SqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<EmployeeVM>("sp_retrieve_employee").ToList();
                return result;
            }
        }
    }
}
