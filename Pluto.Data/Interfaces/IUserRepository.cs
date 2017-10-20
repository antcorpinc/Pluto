
using System;
using Pluto.Models;

namespace Pluto.Data.Interfaces
{
    public interface IUserRepository {

        void AddUser(PlutoUser user);

        PlutoUser GetById(Guid Id);
       
        
    }
}