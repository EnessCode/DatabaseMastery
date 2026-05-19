using DatabaseMasteryTransportMongoDb.Dtos.ShipmentDtos;

namespace DatabaseMasteryTransportMongoDb.Services.ShipmentServices
{
	public interface IShipmentService
	{
		Task<List<ResultShipmentDto>> GetAllShipmentAsync();
		Task<GetShipmentByIdDto> GetShipmentByIdAsync(string id);
		Task CreateShipmentAsync(CreateShipmentDto createShipmentDto);
		Task UpdateShipmentAsync(UpdateShipmentDto updateShipmentDto);
		Task DeleteShipmentAsync(string id);
		Task<GetShipmentByIdDto> GetShipmentByTrackingNumberAsync(string trackingNumber);
		public Task<long> GetTotalShipmentCountAsync();
		public Task<long> GetDeliveredShipmentCountAsync();
		public Task<int> GetDistinctDestinationCityCountAsync();
		public Task<long> GetInDistributionShipmentCountAsync();

	}
}
