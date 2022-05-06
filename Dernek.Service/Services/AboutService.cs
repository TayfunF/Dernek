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
    public class AboutService : Service<About>, IAboutService
    {
        public AboutService(IGenericRepository<About> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
