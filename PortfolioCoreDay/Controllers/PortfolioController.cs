using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioContext conext = new PortfolioContext();
		public IActionResult ProjectList()
		{
			var values = conext.Portfolios.Include(x => x.Category).ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreatePortfolio()
		{
			var values = new SelectList(conext.Categories.ToList(), "CategoryId", "CategoryName");
			ViewBag.v = values;
			return View();
		}
		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			conext.Portfolios.Add(portfolio);
			conext.SaveChanges();
			return RedirectToAction("ProjectList");
		}
	}
}
