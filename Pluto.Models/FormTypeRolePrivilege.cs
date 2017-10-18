using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pluto.Models
{
    public class FormTypeRolePrivilege 
    {  
        [Key]
        public Guid Id {get;set;}
       
        [Required]
        public  Pluto.Models.Enums.FormType FormTypeId {get;set;}
        [Required]
         public Guid RoleId {get;set;}
        
         public string Privileges {get;set;}

         // Relationship
         [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

        [ForeignKey("RoleId")]
         public PlutoRole Roles { get; set; }
     
    }
}