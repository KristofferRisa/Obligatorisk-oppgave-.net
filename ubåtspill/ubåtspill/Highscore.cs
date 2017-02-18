using System;

namespace ubåtspill
{
    [Serializable]
    public class Highscore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Score}";
        }
    }
}
