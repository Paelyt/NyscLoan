//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessA.DataManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoanApproval
    {
        public int ID { get; set; }
        public Nullable<int> LoanApplication_FK { get; set; }
        public Nullable<int> CommentBy { get; set; }
        public string Comment { get; set; }
        public Nullable<int> ApplicationStatus_FK { get; set; }
        public string ValueDate { get; set; }
        public string ValueTime { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> IsVisible { get; set; }
    }
}
