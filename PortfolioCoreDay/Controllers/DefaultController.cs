using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Models;

namespace PortfolioCoreDay.Controllers
{
	public class DefaultController : Controller
	{
		PortfolioContext context= new PortfolioContext();
		public IActionResult Index()
		{
			return View();
		}
	}
}
