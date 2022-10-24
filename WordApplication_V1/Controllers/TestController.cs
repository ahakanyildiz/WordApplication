using Microsoft.AspNetCore.Mvc;

namespace WordApplication_V1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
