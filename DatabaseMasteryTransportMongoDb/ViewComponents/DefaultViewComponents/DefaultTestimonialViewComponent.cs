using DatabaseMasteryTransportMongoDb.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultTestimonialViewComponent : ViewComponent
	{
		private readonly ITestimonialService _testimonialService;

		public DefaultTestimonialViewComponent(ITestimonialService TestimonialService)
		{
			_testimonialService = TestimonialService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _testimonialService.GetAllTestimonialAsync();
			return View(values);
		}
	}
}
