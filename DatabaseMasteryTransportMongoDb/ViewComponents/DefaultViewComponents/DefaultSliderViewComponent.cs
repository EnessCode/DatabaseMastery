using DatabaseMasteryTransportMongoDb.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultSliderViewComponent : ViewComponent
	{
		private readonly ISliderService _sliderService;

		public DefaultSliderViewComponent(ISliderService sliderService)
		{
			_sliderService = sliderService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _sliderService.GetAllSliderAsync();
			return View(values);
		}
	}
}
