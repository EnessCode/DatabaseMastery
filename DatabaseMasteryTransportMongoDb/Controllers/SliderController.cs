using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class SliderController : Controller
	{
		public IActionResult SliderList()
		{
			return View();
		}
	}
}
