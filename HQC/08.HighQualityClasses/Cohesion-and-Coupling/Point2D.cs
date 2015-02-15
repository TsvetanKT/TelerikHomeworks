namespace CohesionAndCoupling
{
    using System;

    public class Figure2D
    {
        public Figure2D(double inputWidth, double inputHeight)
        {
            this.Width = inputWidth;
            this.Height = inputHeight;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double CalcDiagonalXY()
        {
            // Some coupling here, but it's better than repeating the code.
            double distance = CalcDistance.TwoDimensions(0, 0, this.Width, this.Height);
            return distance;
        }
    }
}