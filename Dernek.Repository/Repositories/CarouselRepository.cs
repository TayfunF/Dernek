using Dernek.Core.Models;
using Dernek.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Repository.Repositories
{
    public class CarouselRepository : GenericRepository<Carousel>, ICarouselRepository
    {
        public CarouselRepository(AppDbContext context) : base(context)
        {
        }
    }
}
