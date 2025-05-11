using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
	public class StatisticsController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
			ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
			ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();

			// Education: üniversite sayısı (farklı üniversite)
			ViewBag.v5 = context.Educations.Select(x => x.University).Distinct().Count();

			// Experience: en uzun açıklama karakter sayısı
			ViewBag.v6 = context.Experiences.Max(x => x.Description.Length);

			// Message: okunmamış mesaj sayısı
			ViewBag.v7 = context.Messages.Count(x => !x.IsRead);

			// Portfolio: en çok kullanılan kategori ID’si
			ViewBag.v8 = context.Portfolios
				.GroupBy(x => x.CategoryId)
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key)
				.FirstOrDefault();

			// Service: aktif servis sayısı
			ViewBag.v9 = context.Services.Count(x => x.Status == true);

			// Message: son 7 günde gelen mesaj sayısı
			var oneWeekAgo = DateTime.Now.AddDays(-7);
			ViewBag.v10 = context.Messages.Count(x => x.SendDate >= oneWeekAgo);
			return View();
		}
	}
}
