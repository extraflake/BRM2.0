using API.Models;
using API.Repositories.Data;
using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class InterviewService : GeneralService<Interview, InterviewRepository>
    {
        private readonly InterviewRepository _interviewRepository;

        public InterviewService(InterviewRepository interviewRepository) : base(interviewRepository)
        {
            _interviewRepository = interviewRepository;
        }

        public IEnumerable<InterviewVM> GetInterview()
        {
            return _interviewRepository.GetInterview();
        }
    }
}
