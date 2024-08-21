using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
