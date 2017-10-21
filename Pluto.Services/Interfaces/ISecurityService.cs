using System.Threading.Tasks;
using Pluto.Models;

namespace Pluto.Services.Interfaces{

    public interface ISecurityService{

        Task<bool> Login(Login loginViewModel);
    }
}


