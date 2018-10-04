using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBLR.Data.DataModel;

namespace XBLR.Logic.ViewModel
{
    public class CategoryVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? pid { get; set; }
        public virtual CategoryVM parent { get; set; }
        public virtual ICollection<CategoryVM> childs { get; set; }
    }
}
