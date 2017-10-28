using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Pluto.Models.Enums;

/// <summary>
/// Users in the Pluto application Ex.!-- Nilesh/Hakim/Sajila
/// </summary>

namespace Pluto.Models
{
   public  class PlutoUser : IdentityUser<Guid>
    {
        public PlutoUser(){
            UserFormTypeMappings = new HashSet<UserFormTypeMapping>();
            UserFeatureTypeMappings = new HashSet<UserFeatureTypeMapping>();
        }
        public bool Disabled { get; set; }
        
        public UserType UserType { get; set; }
        public bool IsSuperUser { get; set; }

        public string FirstName {get;set;}
        public string LastName {get;set;}

        // Navigation

        public ICollection<UserFormTypeMapping> UserFormTypeMappings{get;set;}
        public ICollection<UserFeatureTypeMapping> UserFeatureTypeMappings {get;set;} 
    }
}
