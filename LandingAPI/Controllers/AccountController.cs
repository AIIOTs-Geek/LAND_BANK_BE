using Api.Controllers;
using Common.Dtos.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : BaseController

    {
        private readonly IAccountService _accountService;
     

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
         
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            return Response(await _accountService.Login(loginDto));

        }
    }
}
