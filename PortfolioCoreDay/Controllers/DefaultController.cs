using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
	public class DefaultController : Controller
	{
		PortfolioContext context= new PortfolioContext();
		public IActionResult Index()
		{
			var works = context.Works.ToList();
			var about = context.Abouts.FirstOrDefault();
			ViewData["Works"] = works;
			ViewData["Profile"] = about;
			return View();
		}
	}
}
