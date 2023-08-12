using Microsoft.AspNetCore.Mvc;

namespace EnterForum_Consume.ViewComponents.Default
{
    public class _CategoriesPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}