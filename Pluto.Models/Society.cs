using System;
using System.ComponentModel.DataAnnotations;

namespace Pluto.Models
{
    public class Society 
    {        
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

    }
}