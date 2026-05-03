using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
