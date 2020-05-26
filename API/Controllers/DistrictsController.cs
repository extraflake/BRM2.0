using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Services.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : BaseController<District, DistrictService>
    {
        private readonly DistrictService _districtService;

        public DistrictsController(DistrictService districtService) : base(districtService)
        {
            _districtService = districtService;
        }
    }
}