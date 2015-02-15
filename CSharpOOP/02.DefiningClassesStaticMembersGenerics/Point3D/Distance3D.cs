namespace ExercisePoint3D
{
    using System;
    using System.Linq;

    public static class Distance3D
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
        }
    }
}