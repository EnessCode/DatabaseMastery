using DatabaseMasteryTransportMongoDb.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultAboutViewComponent : ViewComponent
	{
		private readonly IAboutService _aboutService;

		public DefaultAboutViewComponent(IAboutService AboutService)
		{
			_aboutService = AboutService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _aboutService.GetAllAboutAsync();
			return View(values);
		}
	}
}
