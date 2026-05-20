using DatabaseMasteryTransportMongoDb.Services.ShipmentServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultStatisticsViewComponent : ViewComponent
	{
		private readonly IShipmentService _shipmentService;
		public DefaultStatisticsViewComponent(IShipmentService shipmentService)
		{
			_shipmentService = shipmentService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			ViewBag.v1 = await _shipmentService.GetTotalShipmentCountAsync();
			ViewBag.v2 = await _shipmentService.GetDeliveredShipmentCountAsync();
			ViewBag.v3 = await _shipmentService.GetDistinctDestinationCityCountAsync();
			ViewBag.v4 = await _shipmentService.GetInDistributionShipmentCountAsync();
			return View();
		}
	}
}
