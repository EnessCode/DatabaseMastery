using DatabaseMasteryTransportMongoDb.Dtos.HowItWorkDtos;

namespace DatabaseMasteryTransportMongoDb.Services.HowItWorkServices
{
	public interface IHowItWorkService
	{
		Task<List<ResultHowItWorkDto>> GetAllHowItWorkAsync();
		Task<GetHowItWorkByIdDto> GetHowItWorkByIdAsync(string id);
		Task CreateHowItWorkAsync(CreateHowItWorkDto createHowItWorkDto);
		Task UpdateHowItWorkAsync(UpdateHowItWorkDto updateHowItWorkDto);
		Task DeleteHowItWorkAsync(string id);
	}
}
