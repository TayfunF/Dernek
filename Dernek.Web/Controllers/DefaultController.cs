using Dernek.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dernek.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IBlogService _blogService;

        public DefaultController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var GetBlogList = await _blogService.TGetAllAsync();

            ViewBag.GetLastBlog = await _blogService.TGetLastBlogAsync();

            ViewBag.Get3Blogs = await _blogService.TGetLast3BlogsAsync();


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
