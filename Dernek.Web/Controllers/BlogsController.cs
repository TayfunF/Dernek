using Dernek.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dernek.Web.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICarouselService _carouselService;

        public BlogsController(IBlogService blogService, ICarouselService carouselService)
        {
            _blogService = blogService;
            _carouselService = carouselService;
        }

        public async Task<IActionResult> Index()
        {
            var GetBlogList = await _blogService.TGetAllAsync();
            ViewBag.GetLastBlog = await _blogService.TGetLastBlogAsync();

            return View(GetBlogList);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            int Id = Convert.ToInt32(id);

            var BlogDetails = await _blogService.TGetByIdAsync(Id);

            if (BlogDetails == null)
            {
                return RedirectToAction("Index");
            }

            return View(BlogDetails);
        }
    }
}
