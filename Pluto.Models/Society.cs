using System;
namespace Pluto.Models
{
    public class Society 
    {        
        public Guid Id {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public string Address {get;set;}
        public string Locality {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string PinCode {get;set;}
    }
}