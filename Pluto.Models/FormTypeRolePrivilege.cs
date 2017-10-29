using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Privileges associated with a role for a form Ex. Secretary  can CR | VW | AP  the contract form
/// </summary>


namespace Pluto.Models
{
    public class FormTypeRolePrivilege 
    {  
        [Key]
        public Guid Id {get;set;}
       
        [Required]
        public  Enums.FormType FormTypeId {get;set;}
        [Required]
         public Guid RoleId {get;set;}
        
         public string Privileges {get;set;}

         // Relationship
         [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

        [ForeignKey("RoleId")]
         public PlutoRole Role { get; set; }
     
    }
}