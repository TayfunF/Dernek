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
    public class DirectorService : Service<Director>, IDirectorService
    {
        public DirectorService(IGenericRepository<Director> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
