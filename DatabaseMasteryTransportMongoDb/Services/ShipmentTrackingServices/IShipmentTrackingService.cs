using DatabaseMasteryTransportMongoDb.Dtos.ShipmentTrackingDtos;

namespace DatabaseMasteryTransportMongoDb.Services.ShipmentTrackingServices
{
	public interface IShipmentTrackingService
	{
		Task<List<ResultShipmentTrackingDto>> GetAllTrackingsAsync(string trackingNumber);
		Task<ResultShipmentTrackingDto> GetTrackingByIndexAsync(string trackingNumber, int index);
		Task CreateTrackingAsync(CreateShipmentTrackingDto createDto);
		Task UpdateTrackingAsync(UpdateShipmentTrackingDto updateDto);
		Task DeleteTrackingAsync(string trackingNumber, int index);
	}
}
