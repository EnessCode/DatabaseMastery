using DatabaseMasteryTransportMongoDb.Services.OfferServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultOfferViewComponent : ViewComponent
	{
		private readonly IOfferService _OfferService;

		public DefaultOfferViewComponent(IOfferService OfferService)
		{
			_OfferService = OfferService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _OfferService.GetAllOfferAsync();
			return View(values);
		}
	}
}
