using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Services.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static API.Bases.BaseTranscationController;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : BaseTransactionController<Interview, InterviewService>
    {
        private readonly InterviewService _interviewService;

        public InterviewsController(InterviewService interviewService) : base(interviewService)
        {
            _interviewService = interviewService;
        }

        [HttpGet("GetInterview")]
        public IActionResult GetInterview()
        {
            var get = _interviewService.GetInterview();
            if (!get.Equals(0))
            {
                return Ok(get);
            }
            return BadRequest();
        }
        [HttpGet("{start}/{end}")]
        public IActionResult GetInterviewSort(string start, string end)
        {
            var get = _interviewService.GetInterviewSort(start, end);
            if (!get.Equals(0))
            {
                return Ok(get);
            }
            return BadRequest();
        }

    }
}