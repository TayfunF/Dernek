using Dernek.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dernek.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICarouselService _carouselService;

        public DefaultController(ICarouselService carouselService)
        {
            _carouselService = carouselService;
        }

        public async Task<IActionResult> Index()
        {
            var GetCarouselList = await _carouselService.TGetAllAsync();

            return View(GetCarouselList);
        }
    }
}
