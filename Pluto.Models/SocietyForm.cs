using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pluto.Models
{
    public class SocietyForm 
    {        
        [Key]
        public Guid Id {get;set;}
        
        public Pluto.Models.Enums.FormType FormTypeId {get;set;}

        public Guid SocietyId {get;set;}

        [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

        [ForeignKey("SocietyId")]
         public Society Society { get; set; }
     
    }
}