using System;
using System.Drawing;

namespace ubåtspill
{
    public class Fiende
    {
        public Fiende(int speed)
        {
            this.Speed = (Speed)speed;

            var random = new Random();

            var newY = random.Next(0, 250);           
            Y = newY;

            //Fienden starter på utsiden av panelet og flytter seg inn fra høyre, derfor random fra -350(en type delay)
            var newX = random.Next(-350, 0); 
            X = newX;
            
            //lager ny tilfeldig point
            Length = random.Next(10,40);

            IsActive = true;
            //Utregning av poengsum baseres på hvor liten fienden er og hvor langt unna den er. 
            //Lagt til ekstra poeng sum bassert på hastighet slow 0 + 1 * 10 = 10, medium = 1 + 1 * 10 = 20, fast = 2 + 1 * 10 = 30 
            Points = (100 - Length) + (25 - Y/10) + (speed + 1*10); 
            Height = 20;

            Brush = new SolidBrush(Color.DarkRed);
        }

        public void Move()
        {
            X++;
        }        

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Points { get; private set; }
        public bool IsActive { get; set; }
        public int Length { get; private set; }
        public int Height { get; private set; }
        public Speed Speed { get; private set; }
        internal bool IsHit(Torpedo torpedo)
        {
            if(torpedo.X == 0)
            {
                return false;
            }

            var radiusX = Length;
            var radiusY = Height;

            var minX = X - radiusX;
            var maxX = X + radiusX;

            var minY = Y - radiusY;
            var maxY = Y + radiusY;

            if (
                (torpedo.X + torpedo.Length) <= maxX
                && 
                (torpedo.X + torpedo.Length) >= minX
                &&
                (torpedo.Y + torpedo.Height) <= maxY
                && 
                (torpedo.Y + torpedo.Height) >= minY
            )
            {
                return true;
            }
            
            return false;
        }
        
        public Brush Brush { get; set; }
    }

    public enum Speed
    {
        Slow,Mid,Fast
    }
}