using System;
namespace Exercise01
{
    public abstract class Shape
    {
        public Shape (double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }

        public abstract double CalculateSurface();
    }
}
