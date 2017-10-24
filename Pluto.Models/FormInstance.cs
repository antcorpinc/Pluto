

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pluto.Models.Enums;

namespace Pluto.Models{
    public class FormInstance {

        public FormInstance()
        {
            FormInstanceApprovers = new HashSet<FormInstanceApprover>();
        }

         [Key]
        public Guid Id {get;set;}
        public Guid SocietyId {get;set;}
        
        public Pluto.Models.Enums.FormStatus FormStatusId {get;set;}

        public DateTime? WorkflowCompletedDate {get;set;}

        public Guid InputterId {get;set;}

        public int? NextApproverOrder {get;set;}

        public Pluto.Models.Enums.FormType FormTypeId{get;set;}

        public Guid? ParentFormId {get;set;}

        public string FormInstanceContent {get;set;}

        //Relationship 

         [ForeignKey("SocietyId")]
         public Society Society { get; set; }

           [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

          [ForeignKey("FormStatusId")]
        public FormStatus FormStatus { get; set; }

        
        //Info: We can't have FK relationship since ParentFormId
        // Can be null so keep no need of the below

       // [ForeignKey("ParentFormId")]
       //  public FormInstance Parent { get; set; }


         //Navigation

        public ICollection<FormInstanceApprover> FormInstanceApprovers{get;set;}
        
    }
}