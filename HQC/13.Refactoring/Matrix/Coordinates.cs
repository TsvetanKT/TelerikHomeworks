namespace DiagonalMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Coordinates
    {
        public Coordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public void Update(int directionX, int directionY)
        {
            this.Row += directionX;
            this.Col += directionY;
        }
    }
}