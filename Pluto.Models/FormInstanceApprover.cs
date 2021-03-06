using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pluto.Models.Enums;


/// <summary>
/// Details of the user who approved the form
/// </summary>

namespace Pluto.Models{
    public class FormInstanceApprover {
        [Key]
        public Guid Id {get;set;}

        public Guid FormInstanceId {get;set;}
        public string Role {get;set;}
        public int Order {get;set;}

        // Can't have FKEy as this could be null
        public Guid SelectedUserId {get;set;}

        public Guid ApprovedByUserId{get;set;}
        public bool IsApproved {get;set;}
        public string Comments {get;set;}
        public string RejectionReason {get;set;}

        //Relationship
        [ForeignKey("FormInstanceId")]
         public FormInstance FormInstance { get; set; }

    }
}