using System.Collections.Generic;

namespace Trafikkal.web.Models.ScoresViewModels
{
    public class ScoresViewModel
    {
        public List<UserScore> UserScores { get; set; }
        public List<Student> Students { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
