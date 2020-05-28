using API.Context;
using API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class DistrictRepository : GeneralRepository<District, MyContext>
    {
        IConfiguration _configuration { get; }

        public DistrictRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }
    }
}
