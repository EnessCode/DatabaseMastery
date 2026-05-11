using DatabaseMasteryTransportMongoDb.Services.BrandServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultBrandViewComponent : ViewComponent
	{
		private readonly IBrandService _brandService;

		public DefaultBrandViewComponent(IBrandService BrandService)
		{
			_brandService = BrandService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _brandService.GetAllBrandAsync();
			return View(values);
		}
	}
}
