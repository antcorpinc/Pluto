using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pluto.Models
{
    public class UserFeatureTypeMapping 
    {  
        [Key]
        public Guid Id {get;set;}
        [Required]
        public Guid UserId {get;set;}
        [Required]
        public Guid SocietyId {get;set;}

        [Required]
        public Guid RoleId {get;set;}

        [Required]
        public Pluto.Models.Enums.FeatureType FeatureTypeId { get;set;}
        
         //  Relationship

        [ForeignKey("UserId")]
         public PlutoUser Users { get; set; }

         [ForeignKey("SocietyId")]
         public Society Society { get; set; }

         [ForeignKey("FeatureTypeId")]
        public FeatureType FeatureType { get; set; }
     
        [ForeignKey("RoleId")]
         public PlutoRole Roles { get; set; }
     
    }
}