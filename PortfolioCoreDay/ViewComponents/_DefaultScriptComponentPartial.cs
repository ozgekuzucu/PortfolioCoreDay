﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
	public class _DefaultScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
