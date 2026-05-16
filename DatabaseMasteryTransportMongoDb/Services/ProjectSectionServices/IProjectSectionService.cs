using DatabaseMasteryTransportMongoDb.Dtos.ProjectSectionDtos;

namespace DatabaseMasteryTransportMongoDb.Services.ProjectSectionServices
{
	public interface IProjectSectionService
	{
		Task<List<ResultProjectSectionDto>> GetAllProjectSectionAsync();
		Task<GetProjectSectionByIdDto> GetProjectSectionByIdAsync(string id);
		Task CreateProjectSectionAsync(CreateProjectSectionDto createProjectSectionDto);
		Task UpdateProjectSectionAsync(UpdateProjectSectionDto updateProjectSectionDto);
		Task DeleteProjectSectionAsync(string id);
	}
}
