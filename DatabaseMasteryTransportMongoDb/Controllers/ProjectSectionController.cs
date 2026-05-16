using DatabaseMasteryTransportMongoDb.Dtos.ProjectSectionDtos;
using DatabaseMasteryTransportMongoDb.Services.ProjectSectionServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class ProjectSectionController : Controller
	{
		private readonly IProjectSectionService _projectSectionService;

		public ProjectSectionController(IProjectSectionService ProjectSectionService)
		{
			_projectSectionService = ProjectSectionService;
		}

		public async Task<IActionResult> ProjectSectionList()
		{
			var values = await _projectSectionService.GetAllProjectSectionAsync();
			return View(values);
		}

		[HttpGet]
		public async Task<IActionResult> CreateProjectSection()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateProjectSection(CreateProjectSectionDto createProjectSectionDto)
		{
			await _projectSectionService.CreateProjectSectionAsync(createProjectSectionDto);
			return RedirectToAction("ProjectSectionList");
		}

		[HttpGet]
		public async Task<IActionResult> DeleteProjectSection(string id)
		{
			await _projectSectionService.DeleteProjectSectionAsync(id);
			return RedirectToAction("ProjectSectionList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateProjectSection(string id)
		{
			var value = await _projectSectionService.GetProjectSectionByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateProjectSection(UpdateProjectSectionDto updateProjectSectionDto)
		{
			await _projectSectionService.UpdateProjectSectionAsync(updateProjectSectionDto);
			return RedirectToAction("ProjectSectionList");
		}
	}
}
