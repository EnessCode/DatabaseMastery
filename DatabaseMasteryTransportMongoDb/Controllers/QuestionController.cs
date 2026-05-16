using DatabaseMasteryTransportMongoDb.Dtos.QuestionDtos;
using DatabaseMasteryTransportMongoDb.Services.QuestionServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMasteryTransportMongoDb.Controllers
{
	public class QuestionController : Controller
	{
		private readonly IQuestionService _questionService;

		public QuestionController(IQuestionService QuestionService)
		{
			_questionService = QuestionService;
		}

		public async Task<IActionResult> QuestionList()
		{
			var values = await _questionService.GetAllQuestionAsync();
			return View(values);
		}

		[HttpGet]
		public async Task<IActionResult> CreateQuestion()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateQuestion(CreateQuestionDto createQuestionDto)
		{
			await _questionService.CreateQuestionAsync(createQuestionDto);
			return RedirectToAction("QuestionList");
		}

		[HttpGet]
		public async Task<IActionResult> DeleteQuestion(string id)
		{
			await _questionService.DeleteQuestionAsync(id);
			return RedirectToAction("QuestionList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateQuestion(string id)
		{
			var value = await _questionService.GetQuestionByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateQuestion(UpdateQuestionDto updateQuestionDto)
		{
			await _questionService.UpdateQuestionAsync(updateQuestionDto);
			return RedirectToAction("QuestionList");
		}
	}
}
