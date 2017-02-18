using System;

namespace ubåtspill
{
    public class Fi
    {
        public Fi()
        {
            //lager en ny tilfeldig Y verdi for utbåt
            var random = new Random();
            var newY = random.Next(0, 250);

            X = 0;
            Y = newY;

            isActive = true;

            //lager ny tilfeldig point
            points = random.Next(10,40);
            Length = points;
            Height = 20;
        }

        public void Move()
        {
            X++;
        }        

        public int X { get; private set; }
        public int Y { get; private set; }
        public int points { get; private set; }
        public bool isActive { get; set; }
        public int Length { get; private set; }
        public int Height { get; private set; }

        internal bool isHit(Torpedo torpedo)
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
    }
}