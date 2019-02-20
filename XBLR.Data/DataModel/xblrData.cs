using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBLR.Data.DataModel
{
    public class xblrData
    {
            public int id { get; set; }
            public string element_name { get; set; }
            [DataType(DataType.Date)]
            public DateTime assessment_year { get; set; }
            [DataType(DataType.Date)]
            public DateTime financial_year { get; set; }
            public string foot_notes { get; set; }
            public string specific_business_rule { get; set; }
    }
}
