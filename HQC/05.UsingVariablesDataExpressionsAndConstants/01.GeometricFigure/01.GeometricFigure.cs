namespace VariablesDataExpressionsConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GeometricFigure
    {
        private double width;
        private double height;

        public GeometricFigure(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and height must be positive!");
            }

            this.Width = width;
            this.Heigth = height;
        }
        
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width must be positive!");
                }
            }
        }

        public double Heigth
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height must be positive!");
                }
            }
        }

        public static GeometricFigure GetRotatedFigure(
            GeometricFigure figure, double angleOfRotation)
        {
            double rotatedSizeWidth = (Math.Abs(Math.Cos(angleOfRotation)) * figure.Width) +
                                    (Math.Abs(Math.Sin(angleOfRotation)) * figure.Heigth);
            double rotatedSizeHeight = (Math.Abs(Math.Sin(angleOfRotation)) * figure.Width) +
                                    (Math.Abs(Math.Cos(angleOfRotation)) * figure.Heigth);

        GeometricFigure rotatedFigure = new GeometricFigure(rotatedSizeWidth, rotatedSizeHeight);

        return rotatedFigure;
        }
    }
}
