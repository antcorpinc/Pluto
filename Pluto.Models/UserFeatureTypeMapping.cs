using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Users belonging to an society with  role and having access to features
// Ex. 'Roni' in 'MontVert' as 'Secretary' can 'AddUser'
/// </summary>

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
        public Enums.FeatureType FeatureTypeId { get;set;}
        
         //  Relationship

        [ForeignKey("UserId")]
         public PlutoUser User { get; set; }

         [ForeignKey("SocietyId")]
         public Society Society { get; set; }

         //Relationship

         [ForeignKey("FeatureTypeId")]
        public FeatureType FeatureType { get; set; }
     
        [ForeignKey("RoleId")]
         public PlutoRole Role { get; set; }
     
    }
}