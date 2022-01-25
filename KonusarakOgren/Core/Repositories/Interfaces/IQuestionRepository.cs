using KonusarakOgren.Application.Models;

namespace KonusarakOgren.Core.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        QuestionAnswerResponse CheckQuestionAnswer(QuestionAnswerRequest request);
    }
}
