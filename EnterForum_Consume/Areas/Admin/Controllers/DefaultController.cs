using Microsoft.AspNetCore.Mvc;

namespace EnterForum_Consume.Areas.Admin.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public DefaultController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
