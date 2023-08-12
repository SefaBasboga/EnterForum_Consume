using Microsoft.AspNetCore.Mvc;

namespace EnterForum_Consume.ViewCompanent.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}