using Microsoft.AspNetCore.Mvc;

namespace EnterForum_Consume.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
