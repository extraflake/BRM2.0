using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IAccountService
    {
        AccountVM Get(LoginVM loginVM);
        AccountVM Post(RegisterVM registerVM);
    }
}
