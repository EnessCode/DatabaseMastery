using DatabaseMasteryTransportMongoDb.Services.GetInTouchServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultGetInTouchViewComponent : ViewComponent
	{
		private readonly IGetInTouchService _getInTouchService;

		public DefaultGetInTouchViewComponent(IGetInTouchService GetInTouchService)
		{
			_getInTouchService = GetInTouchService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _getInTouchService.GetAllGetInTouchAsync();
			return View(values);
		}
	}
}
