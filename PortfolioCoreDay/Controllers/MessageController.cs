using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
	
	public class MessageController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		[HttpPost]
		public IActionResult SendMessage(Message message)
		{
			context.Messages.Add(message);
			context.SaveChanges();
			ViewBag.Success = "Mesajınız Başarıyla İletildi";
			return View("~/Views/Default/Index.cshtml");
		}

	}
}
