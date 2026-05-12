using DatabaseMasteryTransportMongoDb.Services.HowItWorkServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultHowItWorkViewComponent : ViewComponent
	{
		private readonly IHowItWorkService _howItWorkService;

		public DefaultHowItWorkViewComponent(IHowItWorkService HowItWorkService)
		{
			_howItWorkService = HowItWorkService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _howItWorkService.GetAllHowItWorkAsync();
			return View(values);
		}
	}
}
