using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
///  All the features in the Pluto application.-- Ex ManageUser, AddSociety
/// </summary>
namespace Pluto.Models
{
    public class FeatureType 
    {  
        public FeatureType(){
            SocietyFeatures = new HashSet<SocietyFeature>();
            UserFeatureTypeMappings = new HashSet<UserFeatureTypeMapping>();
        }
        [Key]
        public Enums.FeatureType Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string TypeName {get;set;}
        
        [MaxLength(200)]
        public string  Description {get;set;}

        public Enums.FeatureType? ParentFeatureId {get;set;}
        // Used primarily for UI to arrage the order of feartures Ex. In tabs
        public int? Order{get;set;}

        // Navigation
        public ICollection<SocietyFeature> SocietyFeatures {get;set;}
        public ICollection<UserFeatureTypeMapping> UserFeatureTypeMappings{get;set;}

         
    }
}      
