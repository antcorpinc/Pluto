using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Pluto.Models.Enums;

namespace Pluto.Models
{
   public  class PlutoUser : IdentityUser<Guid>
    {
        public bool Disabled { get; set; }
        
        public UserType UserType { get; set; }
        public bool IsSuperUser { get; set; }

        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}
