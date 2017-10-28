using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// All the forms applicable for a society
// Ex.  'MontVert' has the Complaint/Request forms
/// </summary>
namespace Pluto.Models
{
    public class SocietyForm 
    {        
        [Key]
        public Guid Id {get;set;}
        
        public Enums.FormType FormTypeId {get;set;}

        public Guid SocietyId {get;set;}

        //Relationship

        [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

        [ForeignKey("SocietyId")]
         public Society Society { get; set; }
     
    }
}