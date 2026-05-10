using DatabaseMasteryTransportMongoDb.Dtos.BrandDtos;

namespace DatabaseMasteryTransportMongoDb.Services.BrandServices
{
	public interface IBrandService
	{
		Task<List<ResultBrandDto>> GetAllBrandAsync();
		Task<GetBrandByIdDto> GetBrandByIdAsync(string id);
		Task CreateBrandAsync(CreateBrandDto createBrandDto);
		Task UpdateBrandAsync(UpdateBrandDto updateBrandDto);
		Task DeleteBrandAsync(string id);
	}
}
