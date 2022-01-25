namespace KonusarakOgren.Application.Models
{
    public class QuestionAnswerResponse
    {
        public int QuestionId { get; set; }
        public int CorrectOptionId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
