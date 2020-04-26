using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Handlers;
using API.Services.Interface;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }
 
        [HttpPost]
        public IActionResult Get(LoginVM loginVM)
        {
            TokenGenerator tokenGenerator = new TokenGenerator();
            var get = _accountService.Get(loginVM);
            if (get != null)
            {
                var generateToken = tokenGenerator.Generator(get);
                return Ok(generateToken);
            }
            return BadRequest();
        }
    }
}