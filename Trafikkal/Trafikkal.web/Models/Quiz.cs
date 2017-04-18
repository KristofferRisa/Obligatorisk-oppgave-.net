using System;

namespace Trafikkal.web.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Question { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }
        public string Alternative1 { get; set; }
        public string Alternative2 { get; set; }
        public string Alternative3 { get; set; }
        public string Alternative4 { get; set; }
        public string Answer { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
    }
}
