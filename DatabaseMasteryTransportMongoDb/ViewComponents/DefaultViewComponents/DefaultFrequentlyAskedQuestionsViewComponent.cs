using DatabaseMasteryTransportMongoDb.Services.QuestionServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.ViewComponents.DefaultViewComponents
{
	public class DefaultFrequentlyAskedQuestionsViewComponent : ViewComponent
	{
		private readonly IQuestionService _questionService;

		public DefaultFrequentlyAskedQuestionsViewComponent(IQuestionService QuestionService)
		{
			_questionService = QuestionService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _questionService.GetAllQuestionAsync();
			return View(values);
		}
	}
}
