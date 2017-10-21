
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pluto.Models;
using Pluto.Services.Interfaces;

namespace Pluto.Services {

    public class SecurityService : ISecurityService
    {
        private readonly UserManager<PlutoUser> _userManager;
        private readonly SignInManager<PlutoUser> _signInManager;
       
        public SecurityService(UserManager<PlutoUser> userManager,
        SignInManager<PlutoUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(Login loginViewModel)
        {
           var user =  await _userManager.FindByEmailAsync(loginViewModel.UserName);
           if(user !=null)
           {
               var result = await _signInManager.PasswordSignInAsync
               (user, loginViewModel.Password, false, false);
               if(result.Succeeded)
                  return true;
               
                else 
                    return false;
           }
           else 
             return false;
        }
    }

}