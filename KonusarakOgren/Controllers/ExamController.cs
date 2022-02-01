using KonusarakOgren.Application.Interfaces;
using KonusarakOgren.Infrastructure.Data.DataContext;
using KonusarakOgren.Core.Entities;
using KonusarakOgren.Infrastructure.Enum;
using KonusarakOgren.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace KonusarakOgren.Controllers
{
    [Authorize]
    public class ExamController : Controller
    {
        public readonly IExamService _examService;
        
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }
        
        public async Task<IActionResult> Create()
        {
            var response = await _examService.GetWiredArticles();
            return View(response);
        }

        [HttpPost]
        public IActionResult Create(ExamCreateModel model)
        {
            _examService.CreateExam(model);
            return RedirectToAction("List", "Exam");
        }

        public IActionResult List()
        {
            var examList = _examService.GetExams();
            return View(examList);
        }

        public IActionResult Delete(int id)
        {
            _examService.DeleteExam(id);
            return RedirectToAction("List", "Exam");
        }

        public IActionResult Index(int id)
        {
            var exam = _examService.GetExam(id);

            return View(exam);
        }

        public List<QuestionAnswerResponse> CheckQuestionAnswers(List<QuestionAnswerRequest> request)
        {
            return _examService.CheckQuestionAnswers(request);
        }
    }
}