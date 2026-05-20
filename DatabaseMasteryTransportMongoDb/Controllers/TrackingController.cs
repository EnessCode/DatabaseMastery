using DatabaseMasteryTransportMongoDb.Services.ShipmentServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class TrackingController : Controller
	{
		private readonly IShipmentService _shipmentService;

		public TrackingController(IShipmentService shipmentService)
		{
			_shipmentService = shipmentService;
		}

		[HttpGet]
		public async Task<IActionResult> Index(string trackingNumber)
		{
			if (string.IsNullOrEmpty(trackingNumber))
			{
				return View();
			}

			var shipmentDto = await _shipmentService.GetShipmentByTrackingNumberAsync(trackingNumber.Trim());

			ViewBag.SearchedNumber = trackingNumber;
			return View(shipmentDto);
		}
	}
}