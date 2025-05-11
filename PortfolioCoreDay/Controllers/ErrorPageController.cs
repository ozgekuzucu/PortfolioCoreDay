using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Page404()
		{
			return View();
		}
	}
}
