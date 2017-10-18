using System;
namespace Pluto.Models
{
    public class Society 
    {        
        public Guid Id {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public string AddressLine1 {get;set;}
        public string AddressLine2 {get;set;}
        public string Locality {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string PinCode {get;set;}
        public string PhoneNumber {get;set;}
        public string AdditionalPhoneNumber {get;set;}

    }
}