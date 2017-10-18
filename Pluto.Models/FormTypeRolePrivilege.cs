using System;
using System.ComponentModel.DataAnnotations;

namespace Pluto.Models
{
    public class FormTypeRolePrivilege 
    {  
        [Key]
        public Guid Id {get;set;}
       
        public  Pluto.Models.Enums.FormType FormTypeId {get;set;}

         public Guid RoleId {get;set;}

         public string Privileges {get;set;}

         // ToDO: Add Relationship for FormType & Role

    }
}