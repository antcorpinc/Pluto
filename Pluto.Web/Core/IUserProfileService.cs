
using System.Threading.Tasks;
using Pluto.Web.ViewModels;

namespace Pluto.Web.Core {

    public interface IUserProfileService {

       Task<bool> Login(LoginViewModel loginViewModel);
    }
}