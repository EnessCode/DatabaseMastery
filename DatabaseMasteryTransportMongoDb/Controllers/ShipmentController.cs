using DatabaseMasteryTransportMongoDb.Dtos.ShipmentDtos;
using DatabaseMasteryTransportMongoDb.Services.ShipmentServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class ShipmentController : Controller
	{
		private readonly IShipmentService _shipmentService;

		public ShipmentController(IShipmentService ShipmentService)
		{
			_shipmentService = ShipmentService;
		}

		public async Task<IActionResult> ShipmentList()
		{
			var values = await _shipmentService.GetAllShipmentAsync();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateShipment()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateShipment(CreateShipmentDto createShipmentDto)
		{
			await _shipmentService.CreateShipmentAsync(createShipmentDto);
			return RedirectToAction("ShipmentList");
		}

		[HttpGet]
		public async Task<IActionResult> DeleteShipment(string id)
		{
			await _shipmentService.DeleteShipmentAsync(id);
			return RedirectToAction("ShipmentList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateShipment(string id)
		{
			var value = await _shipmentService.GetShipmentByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateShipment(UpdateShipmentDto updateShipmentDto)
		{
			await _shipmentService.UpdateShipmentAsync(updateShipmentDto);
			return RedirectToAction("ShipmentList");
		}
	}
}
