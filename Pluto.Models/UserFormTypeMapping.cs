using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Users belonging to an society with  role and having access to form
/// Ex. Roni from MontVert as treasurer has access to finance/request and complaint forms
/// </summary>

namespace Pluto.Models
{
    public class UserFormTypeMapping 
    {  
        [Key]
        public Guid Id {get;set;}
        [Required]
        public Guid UserId {get;set;}
        [Required]
        public Guid SocietyId {get;set;}
        [Required]
        public Enums.FormType FormTypeId { get;set;}
        [Required]
        public Guid RoleId {get;set;}

        // Is Form Admin ???

        //  Relationship

        [ForeignKey("UserId")]
         public PlutoUser Users { get; set; }

         [ForeignKey("SocietyId")]
         public Society Society { get; set; }

         [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }
     
        [ForeignKey("RoleId")]
         public PlutoRole Roles { get; set; }
     
    }
}