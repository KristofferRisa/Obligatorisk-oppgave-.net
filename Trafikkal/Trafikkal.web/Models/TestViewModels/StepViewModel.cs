using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models.TestViewModels
{
    public class StepViewModel
    {
        public Question Question { get; set; }
        public int NumberOfQuestions { get; set; }
        public int Answered { get; set; }
    }
}
