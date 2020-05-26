using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CustomerRepository : GeneralRepository<Customer, MyContext>
    {
        IConfiguration _configuration { get; }

        public CustomerRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        //public IEnumerable<CustomerVM> GetCustomer()
        //{
        //    using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
        //    {
        //        var result = connection.Query<CustomerVM>("sp_retrieve_customer2").ToList();
        //        return result;
        //    }
        //}

        public IEnumerable<CustomerVM> GetCustomer()
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<CustomerVM>("call sp_retrieve_customer2").ToList();
                return result;
            }
        }
    }
}
