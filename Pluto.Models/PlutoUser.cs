using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Pluto.Models
{
   public  class PlutoUser : IdentityUser<Guid>
    {
        public bool Disabled { get; set; }
        public UserType UserType { get; set; }
        public bool IsSuperUser { get; set; }
    }
}
