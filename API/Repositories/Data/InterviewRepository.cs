using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class InterviewRepository : TransactionRepository<Interview, MyContext>
    {
        IConfiguration _configuration { get; }
        private readonly MyContext _myContext;

        public InterviewRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
            _myContext = myContext;
        }

        public IEnumerable<InterviewVM> GetInterview()
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<InterviewVM>("call sp_retrieve_interview_employee_customer2").ToList();
                return result;
            }
        }
        public IEnumerable<InterviewVM> GetInterviewSort(string start, string end)
        {
            using (var connection = new MySqlConnection(_configuration.GetConnectionString("Storage")))
            {
                var result = connection.Query<InterviewVM>("call sp_retrieve_interview_employee_customer_sort2({start},{end})").ToList();
                return result;
            }
        }
        public async Task<int> FullPost(Interview interview)
        {
            await _myContext.Set<Interview>().AddAsync(interview);
            var result = await _myContext.SaveChangesAsync();
            if (result > 0)
            {
                return result;
            }
            return result;
        }

        public async Task<Interview> GetById(int id)
        {
            var result = await _myContext.Set<Interview>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public async Task<int> FullPut(Interview interview)
        {
            _myContext.Entry(interview).State = EntityState.Modified;
            var result = await _myContext.SaveChangesAsync();
            if (result > 0)
            {
                return result;
            }
            return result;
        }
    }
}
