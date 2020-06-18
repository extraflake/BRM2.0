﻿using API.Models;
using API.Repositories.Data;
using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class InterviewService : TransactionService<Interview, InterviewRepository>
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
        public IEnumerable<InterviewVM> GetInterviewSort(string start, string end)
        {
            return _interviewRepository.GetInterviewSort(start, end);
        }
        public Task<int> FullPost(Interview interview)
        {
            return _interviewRepository.FullPost(interview);
        }

        public Task<Interview> GetById(int id)
        {
            return _interviewRepository.GetById(id);
        }

        public Task<int> FullPut(Interview interview)
        {
            return _interviewRepository.FullPut(interview);
        }
    }
}
