using KonusarakOgren.Core.Entities;
using System.Collections.Generic;

namespace KonusarakOgren.Core.Repositories
{
    public interface IExamRepository
    {
        List<Exam> GetExams();
        Exam GetExam(int examId);
        void CreateExam(Exam exam);
        void DeleteExam(int examId);
    }
}
