using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pluto.Models.Enums;

namespace Pluto.Models{
    public class FormInstanceApprover {
        [Key]
        public Guid Id {get;set;}

        public Guid FormInstanceId {get;set;}
        public string Role {get;set;}
        public int Order {get;set;}
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