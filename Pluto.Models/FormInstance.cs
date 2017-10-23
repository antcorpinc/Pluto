

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pluto.Models.Enums;

namespace Pluto.Models{
    public class FormInstance {

        public FormInstance()
        {
        //    FormInstanceApprovers = new HashSet<FormInstanceApprover>();
        }

         [Key]
        public Guid Id {get;set;}
        public Guid SocietyId {get;set;}
        
        public Pluto.Models.Enums.FormStatus StatusId {get;set;}

        public DateTime WorkflowCompletedDate {get;set;}

        public Guid InputterId {get;set;}

        public int NextApproverOrder {get;set;}

        public Pluto.Models.Enums.FormType FormTypeId{get;set;}

        public Guid ParentFormId {get;set;}

        public string FormInstanceContent {get;set;}

        //Relationship 

         [ForeignKey("SocietyId")]
         public Society Society { get; set; }

           [ForeignKey("FormTypeId")]
        public FormType FormType { get; set; }

        
        //Todo: Later -- Having issues when doing DB update on migrations.
        // For now deleting this constraint - Add later when made changes
        // directly from DB and then reverse engg in sample proj to see
        // Model changes accordingly.

       // [ForeignKey("ParentFormId")]
       //  public FormInstance Parent { get; set; }


         //Navigation

       // public ICollection<FormInstanceApprover> FormInstanceApprovers{get;set;}
        
    }
}