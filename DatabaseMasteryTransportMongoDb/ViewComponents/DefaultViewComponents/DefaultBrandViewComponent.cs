using DatabaseMasteryTransportMongoDb.Services.BrandServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultBrandViewComponent : ViewComponent
	{
		private readonly IBrandService _BrandService;

		public DefaultBrandViewComponent(IBrandService BrandService)
		{
			_BrandService = BrandService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _BrandService.GetAllBrandAsync();
			return View(values);
		}
	}
}
