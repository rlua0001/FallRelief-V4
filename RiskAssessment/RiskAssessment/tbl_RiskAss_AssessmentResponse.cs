//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RiskAssessment
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_RiskAss_AssessmentResponse
    {
        public System.Guid id { get; set; }
        public int AssessmentNo { get; set; }
        public int AssQuestionID { get; set; }
        public int responseID { get; set; }
        public string Answer { get; set; }
    
        public virtual tbl_RiskAss_Session tbl_RiskAss_Session { get; set; }
        public virtual tbl_RiskAss_AssQuestion tbl_RiskAss_AssQuestion { get; set; }
        public virtual tbl_RiskAss_ResponseChoice tbl_RiskAss_ResponseChoice { get; set; }
    }
}
