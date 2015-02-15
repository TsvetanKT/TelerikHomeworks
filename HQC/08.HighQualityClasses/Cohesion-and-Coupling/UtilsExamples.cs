namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            // Console.WriteLine(GetFile.Extension("example"));  // Exception.
            Console.WriteLine(GetFile.Extension("example.pdf"));
            Console.WriteLine(GetFile.Extension("example.new.pdf"));

            // Console.WriteLine(GetFile.Name("example"));  // Exception.
            Console.WriteLine(GetFile.Name("example.pdf"));
            Console.WriteLine(GetFile.Name("example.new.pdf"));

            // Using CalcDistance as some kind of calculator, so it shoud be static class.
            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                CalcDistance.TwoDimensions(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                CalcDistance.ThreeDimensions(5, 2, -1, 3, -6, 4));

            // Figures are better to have instances -> non-static classes.
            Figure3D testFigure = new Figure3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", testFigure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", testFigure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XZ = {0:f2}", testFigure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", testFigure.CalcDiagonalYZ());
        }
    }
}
