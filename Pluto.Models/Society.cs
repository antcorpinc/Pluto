using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pluto.Core.Contracts;

namespace Pluto.Models
{
    /// <summary>
/// Represents the all societies  in the Pluto - Ex. MontVert ...
/// </summary>
    public class Society : IIdentifiableModel<Guid>
    {        
        public Society() {
            SocietyForms = new HashSet<SocietyForm>();
            SocietyFeatures = new HashSet<SocietyFeature>();
            UserFormTypeMappings = new HashSet<UserFormTypeMapping>();
            UserFeatureTypeMappings = new HashSet<UserFeatureTypeMapping>();
        }
        [Key]
        public Guid Id {get;set;}
        [Required]
        public string Name {get;set;}
        public string Description {get;set;}
        [Required]
        public string AddressLine1 {get;set;}
        public string AddressLine2 {get;set;}
        public string Locality {get;set;}
        [Required]
        public string City {get;set;}
        [Required]
        public string State {get;set;}
        [Required]
        public string PinCode {get;set;}
        public string PhoneNumber {get;set;}
        public string AdditionalPhoneNumber {get;set;}

        //Navigation
        public ICollection<SocietyForm> SocietyForms {get;set;}
        public ICollection<SocietyFeature> SocietyFeatures {get;set;}
        public ICollection<UserFormTypeMapping> UserFormTypeMappings {get;set;}
        public ICollection<UserFeatureTypeMapping> UserFeatureTypeMappings {get;set;}
        
    }
}