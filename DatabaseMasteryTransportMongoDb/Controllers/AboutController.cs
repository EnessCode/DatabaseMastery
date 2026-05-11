using DatabaseMasteryTransportMongoDb.Dtos.AboutDtos;
using DatabaseMasteryTransportMongoDb.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class AboutController : Controller
	{
		private readonly IAboutService _aboutService;

		public AboutController(IAboutService AboutService)
		{
			_aboutService = AboutService;
		}

		public async Task<IActionResult> AboutList()
		{
			var values = await _aboutService.GetAllAboutAsync();
			return View(values);
		}

		[HttpGet]
		public async Task<IActionResult> CreateAbout()
		{
			var values = await _aboutService.GetAllAboutAsync();
			if (values.Any())
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
		{
			await _aboutService.CreateAboutAsync(createAboutDto);
			return RedirectToAction("AboutList");
		}

		[HttpGet]
		public async Task<IActionResult> DeleteAbout(string id)
		{
			await _aboutService.DeleteAboutAsync(id);
			return RedirectToAction("AboutList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateAbout(string id)
		{
			var value = await _aboutService.GetAboutByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
		{
			await _aboutService.UpdateAboutAsync(updateAboutDto);
			return RedirectToAction("AboutList");
		}
	}
}
