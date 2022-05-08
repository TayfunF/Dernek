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


            return View(GetBlogList);
        }
    }
}
