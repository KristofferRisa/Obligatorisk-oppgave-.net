using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models
{
    public class QuestionViewModel
    {
        public Question Question { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
