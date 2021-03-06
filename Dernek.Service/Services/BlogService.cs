using Dernek.Core.Models;
using Dernek.Core.Repositories;
using Dernek.Core.Services;
using Dernek.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Service.Services
{
    public class BlogService : Service<Blog>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IGenericRepository<Blog> repository, IUnitOfWork unitOfWork, IBlogRepository blogRepository) : base(repository, unitOfWork)
        {
            _blogRepository = blogRepository;
        }

        public async Task<IEnumerable<Blog>> TGetLastBlogAsync()
        {
            return await _blogRepository.GetLastBlogAsync();
        }

        public async Task<IEnumerable<Blog>> TGetLast3BlogsAsync()
        {
            return await _blogRepository.GetLast3BlogsAsync();
        }
    }
}
