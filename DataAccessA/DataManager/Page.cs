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
    
    public partial class Page
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string PageUrl { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public string ValueDate { get; set; }
        public string PageDescription { get; set; }
        public Nullable<int> PageHeader { get; set; }
    
        public virtual pageHeader pageHeader1 { get; set; }
    }
}