using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
	public class _DefaultContactMeComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
