using System;
using System.Drawing;

namespace ubåtspill
{
    internal class Ubåt
    {   
        public Ubåt()
        {
            Brush = new SolidBrush(Color.SteelBlue);
            X = 250;
            Y = 290;
            Length = 120;
        }
        
        public SolidBrush Brush { get; private set; }
        public int Y { get; private set; }
        public int X { get; private set; }
        public int Length { get; private set; }

        internal void MoveLeft()
        {
            X -= 10;
        }

        internal void MoveRight()
        {
            X += 10;
        }
    }
}