using Dernek.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dernek.Web.Controllers
{
    public class AboutController : Controller
    {
        private IAboutService _aboutService;

        public AboutController(IAboutService service)
        {
            _aboutService = service;
        }

        public async Task<IActionResult> Index()
        {
            var GetAbout = await _aboutService.TGetAllAsync();

            return View(GetAbout);
        }
    }
}
