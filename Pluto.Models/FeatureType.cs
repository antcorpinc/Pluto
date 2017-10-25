using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pluto.Models
{
    public class FeatureType 
    {  
        [Key]
        public Pluto.Models.Enums.FeatureType Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string TypeName {get;set;}
        
        [MaxLength(200)]
        public string  Description {get;set;}

        public Pluto.Models.Enums.FeatureType? ParentFeatureId {get;set;}
        public int? Order{get;set;}
         
    }
}      
