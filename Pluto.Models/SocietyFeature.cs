using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pluto.Models
{
    public class SocietyFeature
    {        
        [Key]
        public Guid Id {get;set;}
        
        public Pluto.Models.Enums.FeatureType FeatureTypeId {get;set;}

        public Guid SocietyId {get;set;}

        [ForeignKey("FeatureTypeId")]
        public FeatureType FeatureType { get; set; }

        [ForeignKey("SocietyId")]
         public Society Society { get; set; }
     
    }
}