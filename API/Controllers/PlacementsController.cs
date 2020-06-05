using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static API.Bases.BaseTranscationController;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacementsController : BaseTransactionController<Placement, PlacementService>
    {
        private readonly PlacementService _placementService;

        public PlacementsController(PlacementService placementService) : base(placementService)
        {
            _placementService = placementService;
        }
    }
}