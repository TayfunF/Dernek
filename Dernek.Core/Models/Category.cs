using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        ////Navigation Property
        public ICollection<Blog> Blogs { get; set; }
    }
}
