using Microsoft.AspNetCore.Mvc;

namespace EnterForum_Consume.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
