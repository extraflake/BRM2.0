using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Services;
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

        [HttpPost()]
        [Route("FullPost")]
        public async Task<ActionResult<Interview>> FullPost(Interview interview)
        {
            interview.Created_By = "13144";
            interview.Create_Datetime = DateTimeOffset.Now;
            var post = await _interviewService.FullPost(interview);
            return Ok(post);
        }

        [HttpPut()]
        [Route("FullPut/{id}")]
        public async Task<ActionResult> FullPut(int id, Interview interview)
        {
            var put = await _interviewService.GetById(id);
            if (put == null)
            {
                return NotFound();
            }
            else if (interview.interview_datetime != null)
            {
                put.interview_datetime = interview.interview_datetime;
            }
            else if (interview.PIC != null)
            {
                put.PIC = interview.PIC;
            }
            else if (interview.Note != null)
            {
                put.Note = interview.Note;
            }
            else if (interview.Department != null)
            {
                put.Department = interview.Department;
            }
            else if (interview.Employee != null)
            {
                put.Employee = interview.Employee;
            }
            else if (interview.Customer != null)
            {
                put.Customer = interview.Customer;
            }
            else if (interview.Created_By != null)
            {
                put.Created_By = interview.Created_By;
            }
            else if (interview.Create_Datetime != null)
            {
                put.Create_Datetime = interview.Create_Datetime;
            }
            put.Updated_By = "13144";
            put.Update_Datetime = DateTimeOffset.Now;
            await _interviewService.FullPut(put);
            return NoContent();
        }
    }
}