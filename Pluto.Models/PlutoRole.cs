using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

/// <summary>
/// Roles in the Pluto application Ex.!-- Treasures/Secretary/Chairman
/// </summary>

namespace Pluto.Models
{
    public class PlutoRole : IdentityRole<Guid>
    {
        public PlutoRole(){
            FormTypeRolePrivileges = new HashSet<FormTypeRolePrivilege>();
            UserFormTypeMappings = new HashSet<UserFormTypeMapping>();
            UserFeatureTypeMappings = new HashSet<UserFeatureTypeMapping>();
        }

        // Navigation
        public ICollection<FormTypeRolePrivilege> FormTypeRolePrivileges{get;set;}
        public ICollection<UserFormTypeMapping> UserFormTypeMappings {get;set;}
        public ICollection<UserFeatureTypeMapping> UserFeatureTypeMappings {get;set;}
    }
}
