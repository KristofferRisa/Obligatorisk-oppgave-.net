using System;

namespace ubåtspill.Models
{
    [Serializable]
    public class Highscore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Score}";
        }
    }
}
