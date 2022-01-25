using KonusarakOgren.Core.Entities;
using KonusarakOgren.Application.Models;
using KonusarakOgren.Application.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Interfaces
{
    public interface IExamService
    {
        Task<List<Article>> GetWiredArticles();
        List<Exam> GetExams();
        Exam GetExam(int id);
        void CreateExam(ExamCreateModel model);
        void DeleteExam(int examId);
        List<QuestionAnswerResponse> CheckQuestionAnswers(List<QuestionAnswerRequest> request);
    }
}
