using DatabaseMasteryTransportMongoDb.Dtos.GetInTouchDtos;

namespace DatabaseMasteryTransportMongoDb.Services.GetInTouchServices
{
	public interface IGetInTouchService
	{
		Task<List<ResultGetInTouchDto>> GetAllGetInTouchAsync();
		Task<GetGetInTouchByIdDto> GetGetInTouchByIdAsync(string id);
		Task CreateGetInTouchAsync(CreateGetInTouchDto createGetInTouchDto);
		Task UpdateGetInTouchAsync(UpdateGetInTouchDto updateGetInTouchDto);
		Task DeleteGetInTouchAsync(string id);
	}
}
