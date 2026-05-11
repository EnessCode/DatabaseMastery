using DatabaseMasteryTransportMongoDb.Services.OfferServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultOfferViewComponent : ViewComponent
	{
		private readonly IOfferService _offerService;

		public DefaultOfferViewComponent(IOfferService OfferService)
		{
			_offerService = OfferService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _offerService.GetAllOfferAsync();
			return View(values);
		}
	}
}
