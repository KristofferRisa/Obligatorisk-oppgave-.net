using System;
using System.Drawing;

namespace ubåtspill
{
    internal class Torpedo
    {
        internal bool isActive;

        public Torpedo()
        {
            isActive = false;
            Height = 20;
            Length = 20;
            Brush = new SolidBrush(System.Drawing.Color.Red);
        }

        //Spill brett er 1300 x 600 (X = 1300, Y = 600)

        public int X { get; private set; }
        public int Y { get; private set; }
        public float Height { get; internal set; }
        public float Length { get; internal set; }
        public Brush Brush { get; internal set; }

        public void Shoot(int x, int y)
        {
            isActive = true;
            X = x;
            Y = y;
        }

        internal void Move()
        {
            Y--;
        }
    }
}