using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class InterviewRepository : GeneralRepository<Interview, MyContext>
    {
        IConfiguration _configuration { get; }

        public InterviewRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }

        public IEnumerable<InterviewVM> GetInterview()
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<InterviewVM>("call sp_retrieve_interview_employee_customer2").ToList();
                return result;
            }
        }
    }
}
