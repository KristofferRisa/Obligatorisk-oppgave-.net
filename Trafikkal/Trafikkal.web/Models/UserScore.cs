namespace Trafikkal.web.Models
{
    public class UserScore
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuizId { get; set; }
        public decimal Points { get; set; }
    }
}
