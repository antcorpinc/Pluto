using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Pluto.Entities
{
   public  class PlutoUser : IdentityUser<Guid>
    {
        public bool Disabled { get; set; }
    }
}
