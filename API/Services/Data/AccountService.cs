using API.Repositories.Interface;
using API.Services.Interface;
using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class AccountService : IAccountService
    {
        IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public AccountVM Get(LoginVM loginVM)
        {
            return _accountRepository.Get(loginVM);
        }

        public AccountVM Post(RegisterVM registerVM)
        {
            return _accountRepository.Post(registerVM);
        }
    }
}
