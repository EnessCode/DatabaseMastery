using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultBrandViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
