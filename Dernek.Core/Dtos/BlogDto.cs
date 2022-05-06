using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Dtos
{
    public class BlogDto : BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string ThumbnailImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}
