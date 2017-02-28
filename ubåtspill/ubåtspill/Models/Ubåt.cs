using System.Drawing;

namespace ubåtspill.Models
{
    internal class Ubåt
    {
        #region ctor
        public Ubåt()
        {
            Brush = new SolidBrush(Color.SteelBlue);
            X = 250;
            Y = 290;
            Length = 120;
        }
        #endregion

        #region public fields
        public SolidBrush Brush { get; private set; }
        public int Y { get; private set; }
        public int X { get; private set; }
        public int Length { get; private set; }
        #endregion

        #region methods
        internal void MoveLeft()
        {
            X -= 10;
        }

        internal void MoveRight()
        {
            X += 10;
        }
        #endregion
    }
}