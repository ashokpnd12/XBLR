using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBLR.Data.DataModel;

namespace XBLR.Data
{
    public class Context: DbContext
    {
        public Context() : base("xblrConnection") { }

        public DbSet<Category> categories { get; set; }
    }
}
