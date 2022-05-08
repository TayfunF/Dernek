using Microsoft.AspNetCore.Mvc;

namespace Dernek.Web.Controllers
{
    public class DirectorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
