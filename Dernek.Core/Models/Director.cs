using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Models
{
    public class Director : BaseEntity
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Image { get; set; }
    }
}
