using DatabaseMasteryTransportMongoDb.Services.ProjectSectionServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultWhatWeHaveDoneViewComponent : ViewComponent
	{
		private readonly IProjectSectionService _projectSectionService;

		public DefaultWhatWeHaveDoneViewComponent(IProjectSectionService ProjectSectionService)
		{
			_projectSectionService = ProjectSectionService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _projectSectionService.GetAllProjectSectionAsync();
			return View(values);
		}
	}
}
