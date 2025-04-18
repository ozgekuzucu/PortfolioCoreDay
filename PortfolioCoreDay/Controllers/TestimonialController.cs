using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
	public class TestimonialController : Controller
	{
		PortfolioContext context = new PortfolioContext();

		public IActionResult TestimonialList()
		{
			var values = context.Testimonials.ToList();
			return View(values);
		}
		[HttpGet]//sadece sayfa yüklendiği zaman çalışacak
		public IActionResult CreateTestimonial()
		{
			return View();
		}
		[HttpPost]//sayfada bir butona tıklayıp işlemleri tetiklendiğinde çalışacak
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			context.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			context.Testimonials.Remove(value);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		[HttpGet]//güncelleme işlemi iki aşamada yapılır güncellenecek veriler sayfaya taşınır
		public IActionResult UpdateTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
	}
}
