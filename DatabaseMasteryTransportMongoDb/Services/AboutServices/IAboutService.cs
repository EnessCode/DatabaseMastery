using DatabaseMasteryTransportMongoDb.Dtos.AboutDtos;

namespace DatabaseMasteryTransportMongoDb.Services.AboutServices
{
	public interface IAboutService
	{
		Task<List<ResultAboutDto>> GetAllAboutAsync();
		Task<GetAboutByIdDto> GetAboutByIdAsync(string id);
		Task CreateAboutAsync(CreateAboutDto createAboutDto);
		Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);
		Task DeleteAboutAsync(string id);
	}
}
