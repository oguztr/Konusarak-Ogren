using System.Collections.Generic;

namespace KonusarakOgren.Application.Models
{
    public class ExamCreateModel
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public List<ExamQuestionModel> Questions { get; set; }
    }
}
