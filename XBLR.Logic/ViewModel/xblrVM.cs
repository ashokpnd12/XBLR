using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBLR.Logic.ViewModel
{
    public class xblrVM
    {
        [Display(Name = "Element Name")]
        public string element_name { get; set; }
        [Display(Name = "Assessment Year")]
        public string assessment_year { get; set; }
        [Display(Name = "Financial Year")]
        public string financial_year { get; set; }
        [Display(Name = "Foot Notes")]
        public string foot_notes { get; set; }
        [Display(Name = "Specific Business Rule")]
        public string specific_business_rule { get; set; }
    }
}
