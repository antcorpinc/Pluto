using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// All the features applicable to a society
// Ex.  'MontVert' has fearures like ViewReports/ManageRoles 
/// </summary>

namespace Pluto.Models
{
    public class SocietyFeature
    {        
        [Key]
        public Guid Id {get;set;}
        
        public Enums.FeatureType FeatureTypeId {get;set;}

        public Guid SocietyId {get;set;}

        //Relationship

        [ForeignKey("FeatureTypeId")]
        public FeatureType FeatureType { get; set; }

        [ForeignKey("SocietyId")]
         public Society Society { get; set; }
     
    }
}