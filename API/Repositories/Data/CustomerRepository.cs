using API.Context;
using API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
        //    using (var connection = new SqlConnection(_configuration.GetConnectionString("Storage")))
        //    {
        //        var result = connection.Query<CustomerVM>("sp_retrieve_customer2").ToList();
        //        return result;
        //    }
        //}
    }
}
