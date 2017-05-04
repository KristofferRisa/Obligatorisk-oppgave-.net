using System.Collections.Generic;

namespace Trafikkal.web.Models.TestViewModels
{
    public class QuestionViewModel
    {
        public Question Question { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
