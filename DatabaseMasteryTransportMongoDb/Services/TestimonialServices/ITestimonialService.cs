using DatabaseMasteryTransportMongoDb.Dtos.TestimonialDtos;

namespace DatabaseMasteryTransportMongoDb.Services.TestimonialServices
{
	public interface ITestimonialService
	{
		Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
		Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string id);
		Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
		Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
		Task DeleteTestimonialAsync(string id);
	}
}
