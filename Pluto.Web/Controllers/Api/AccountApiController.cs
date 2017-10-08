using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pluto.Web.Core;
using Pluto.Web.ViewModels;

namespace Pluto.Web.Controllers.Api
{
    [Authorize]
    //[Route("api/account")]
    [Route("[controller]/[action]")]
    
    public class AccountApiController:Controller {

        IUserProfileService _userProfileService;
        public AccountApiController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<bool> Login(LoginViewModel loginViewModel)
        {
            return  await _userProfileService.Login(loginViewModel);        
        }      
    }
}