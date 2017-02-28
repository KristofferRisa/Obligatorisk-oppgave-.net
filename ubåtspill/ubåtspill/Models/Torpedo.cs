using System.Drawing;

namespace ubåtspill.Models
{
    internal class Torpedo
    { 
        public Torpedo()
        {
            IsActive = false;
            Height = 20;
            Length = 20;
            Brush = new SolidBrush(System.Drawing.Color.Black);
        }

        //Spill brett er 1300 x 600 (X = 1300, Y = 600)

        public int X { get; private set; }
        public int Y { get; private set; }
        public float Height { get; internal set; }
        public float Length { get; internal set; }
        public Brush Brush { get; internal set; }
        internal bool IsActive;
        public void Shoot(int x, int y)
        {
            IsActive = true;
            X = x;
            Y = y;
        }

        public void Move()
        {
            Y--;
        }
    }
}