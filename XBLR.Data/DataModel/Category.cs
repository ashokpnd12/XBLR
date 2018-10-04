using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBLR.Data.DataModel
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? pid { get; set; }
        [ForeignKey("pid")]
        public virtual Category parent { get; set; }
        public virtual ICollection<Category> childs { get; set; }
    }
}
