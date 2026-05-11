using DatabaseMasteryTransportMongoDb.Dtos.OfferDtos;

namespace DatabaseMasteryTransportMongoDb.Services.OfferServices
{
	public interface IOfferService
	{
		Task<List<ResultOfferDto>> GetAllOfferAsync();
		Task<GetOfferByIdDto> GetOfferByIdAsync(string id);
		Task CreateOfferAsync(CreateOfferDto createOfferDto);
		Task UpdateOfferAsync(UpdateOfferDto updateOfferDto);
		Task DeleteOfferAsync(string id);
	}
}
