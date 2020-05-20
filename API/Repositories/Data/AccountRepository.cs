using API.Repositories.Interface;
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
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        IConfiguration _configuration { get; }

        public AccountVM Get(LoginVM loginVM)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("MyConnection")))
            {
                var result = connection.Query<AccountVM>("SP_Retrieve_AspNetUsers_AspNetRoles @email = @Email, @password = @Password", new { email = loginVM.Email, password = loginVM.Password }).SingleOrDefault();
                return result;
            }
        }

        public AccountVM Post(RegisterVM registerVM)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("MyConnection")))
            {
                var result = connection.Query<AccountVM>("SP_Insert_AspNetUsers @email = @Email, @password = @Password", new { email = registerVM.Email, password = registerVM.Password }).SingleOrDefault();
                return result;
            }
        }
    }
}
