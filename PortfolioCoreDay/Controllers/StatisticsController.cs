using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
	public class StatisticsController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Index()
		{
			//yetenek sayısı
			ViewBag.v0 = "+++++++";
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
			ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
			ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();
			//proje sayısı
			ViewBag.v5 = context.Portfolios.Count();
			//gelen mesaj sayısı
			ViewBag.v5 = context.Messages.Count();
			//rastgele sayı
			Random random = new Random();
			int rnd = random.Next(10, 30);
			ViewBag.v5 = rnd;
			return View();
		}
	}
}
