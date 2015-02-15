namespace CohesionAndCoupling
{
    using System;

    public class Figure3D : Figure2D
    {
        public Figure3D(double inputWidth, double inputHeight, double inputDepth)
            : base(inputWidth, inputHeight)
        {
            this.Depth = inputDepth;
        }

        public double Depth { get; set; }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance.ThreeDimensions(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance.TwoDimensions(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance.TwoDimensions(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}