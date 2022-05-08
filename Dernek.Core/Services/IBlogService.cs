using Dernek.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Core.Services
{
    public interface IBlogService : IService<Blog>
    {
        Task<IEnumerable<Blog>> TGetLast3BlogAsync();
    }
}
