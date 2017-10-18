using System;
using System.ComponentModel.DataAnnotations;

namespace Pluto.Models
{
    public class FormType 
    {  
        [Key]
        public Pluto.Models.Enums.FormType Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string TypeName {get;set;}
        
        [MaxLength(200)]
        public string Description {get;set;}
    }
}      
