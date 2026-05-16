using DatabaseMasteryTransportMongoDb.Dtos.QuestionDtos;

namespace DatabaseMasteryTransportMongoDb.Services.QuestionServices
{
	public interface IQuestionService
	{
		Task<List<ResultQuestionDto>> GetAllQuestionAsync();
		Task<GetQuestionByIdDto> GetQuestionByIdAsync(string id);
		Task CreateQuestionAsync(CreateQuestionDto createQuestionDto);
		Task UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto);
		Task DeleteQuestionAsync(string id);
	}
}
