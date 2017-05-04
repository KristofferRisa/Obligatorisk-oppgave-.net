using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models
{
    public class Score
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuizId { get; set; }
        public decimal Points { get; set; }
    }
}
