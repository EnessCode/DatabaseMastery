using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
