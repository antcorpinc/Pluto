using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// All applicable FormStatuses in the Pluto application Ex.Created/Submitted/Approved/Rejected
/// </summary>

// Todo: Add Navigation to FormInstance.
namespace Pluto.Models
{
    public class FormStatus 
    {  
        [Key]
        public Enums.FormStatus Id {get;set;}

        [Required]
        [MaxLength(30)]
        public string StatusName {get;set;}
        
        [MaxLength(200)]
        public string Description {get;set;}
    }
}      
