using System;
using System.ComponentModel.DataAnnotations;

namespace Pluto.Models
{
    public class FormStatus 
    {  
        [Key]
        public Pluto.Models.Enums.FormStatus Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string StatusName {get;set;}
        
        [MaxLength(200)]
        public string Description {get;set;}
    }
}      
