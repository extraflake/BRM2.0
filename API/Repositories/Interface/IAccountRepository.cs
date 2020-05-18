using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    public interface IAccountRepository
    {
        AccountVM Get(LoginVM loginVM);
        AccountVM Post(RegisterVM registerVM);
    }
}
