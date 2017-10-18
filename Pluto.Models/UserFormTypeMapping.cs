using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Pluto.Models.Enums.FormType FormTypeId { get;set;}
        [Required]
        public Guid RoleId {get;set;}

        // Is Form Admin ???

        // ToDO: Add Relations 

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