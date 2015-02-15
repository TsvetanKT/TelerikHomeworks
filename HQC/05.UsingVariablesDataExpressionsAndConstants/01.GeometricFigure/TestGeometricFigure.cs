namespace VariablesDataExpressionsConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestGeometricFigure
    {
        public static void PrintFigureWidthAndHeight(GeometricFigure figure)
        {
            Console.WriteLine("Figure width:{0,6:F2}", figure.Width);
            Console.WriteLine("Figure height:{0,5:F2}", figure.Heigth);
        }

        public static void Main()
        {
            GeometricFigure original = new GeometricFigure(3, 6);
            PrintFigureWidthAndHeight(original);

            GeometricFigure rotated = GeometricFigure.GetRotatedFigure(original, 90);
            Console.WriteLine("\nRotated figure:");
            PrintFigureWidthAndHeight(rotated);
        }
    }
}
