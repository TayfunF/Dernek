using Dernek.Core.Models;
using Dernek.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Repository.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Blog>> GetLast3BlogAsync()
        {
            return await _context.Blogs.OrderByDescending(x => x.Id).Take(3).ToListAsync();
        }
    }
}
