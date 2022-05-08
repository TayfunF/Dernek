using Dernek.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dernek.Web.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        public async Task<IActionResult> Index()
        {
            var GetDirectorList = await _directorService.TGetAllAsync();

            return View(GetDirectorList);
        }
    }
}
