//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYJ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GOAL
    {
        public int goalID { get; set; }
        [Display(Name = "Goal Period")]
        public string period { get; set; }
        [Display(Name = "Actual Value")]
        public Nullable<int> actualValue { get; set; }
        [Display(Name = "Goal Value")]
        public Nullable<int> goalValue { get; set; }
        [Display(Name = "Fiscal Year")]
        public Nullable<int> fiscalYear { get; set; }
        [Display(Name = "Subcategory")]
        public string subcategory { get; set; }
        [Display(Name = "Category")]
        public string category { get; set; }
        [Display(Name = "Workstream")]
        public string workstream { get; set; }
        [Display(Name = "Team")]
        public string team { get; set; }
    }
}
