using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
	public class _DefaultStatisticComponentPartial: ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = context.Skills.Count();//Yetenek Sayısı
			ViewBag.v2 = context.Portfolios.Count();//Proje Sayısı
			ViewBag.v3 = context.Messages.Count();//Gelen Mesaj Sayısı
			Random random = new Random();
			int rnd = random.Next(10, 31);//Rastgele Sayı(10-30)
			ViewBag.v4 = rnd;
			return View();
		}
	}
}
