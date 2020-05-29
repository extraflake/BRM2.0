using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employee, MyContext>
    {
        IConfiguration _configuration { get; }

        DynamicParameters parameters = new DynamicParameters();

        public EmployeeRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<EmployeeVM> GetEmployee()
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<EmployeeVM>("call sp_retrieve_employee2").ToList();
                return result;
            }
        }

        public async Task<IEnumerable<EmployeeRoleVM>> GetEmployeeRole(int Id)
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var procName = "sp_retrieve_employee_role_by_id2"; //
                parameters.Add("@id", Id);

                var result = await connection.QueryAsync<EmployeeRoleVM>(procName, parameters, commandType: CommandType.StoredProcedure); //await ada jeda. bermanfaat untuk banyak data
                return result;
            }
        }
    }
}
