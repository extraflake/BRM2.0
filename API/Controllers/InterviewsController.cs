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

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : BaseController<Interview, InterviewService>
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

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Interview>> Get(int id)
        {
            var get = await _interviewService.GetById(id);
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPut("PutById/{id}")]
        public async Task<ActionResult> Put(int id, Interview interview)
        {
            await _interviewService.Put(interview);
            return NoContent();
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<ActionResult<int>> Delete(int id)
        {
            var delete = await _interviewService.DeleteById(id);
            if (delete.Equals(0))
            {
                return NotFound();
            }
            return delete;
        }
    }
}