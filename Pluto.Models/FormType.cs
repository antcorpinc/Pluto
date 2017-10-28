using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// FormTypes in the Pluto application Ex.!-- Complaint/request
/// </summary>

namespace Pluto.Models
{
    public class FormType 
    {  
        public FormType(){
            SocietyForms = new HashSet<SocietyForm>();
            FormTypeRolePrivileges = new HashSet<FormTypeRolePrivilege>();
            UserFormTypeMappings = new HashSet<UserFormTypeMapping>();
       
        }
        [Key]
        public Enums.FormType Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string TypeName {get;set;}
        
        [MaxLength(200)]
        public string Description {get;set;}

        //Navigation
        public ICollection<SocietyForm> SocietyForms{get;set;} 
        public ICollection<FormTypeRolePrivilege> FormTypeRolePrivileges {get;set;}
        public ICollection<UserFormTypeMapping> UserFormTypeMappings{get;set;}
       
    }
}      
