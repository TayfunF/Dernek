using Microsoft.AspNetCore.Mvc;

namespace Dernek.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
