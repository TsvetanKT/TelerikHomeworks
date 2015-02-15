namespace ExercisePoint3D
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        public List<Point3D> path = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
            private set
            {
                this.path = value;
            }
        }
        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }
        public void PrintPathList()
        {
            foreach (var i in path)
            {
                Console.WriteLine("3D Point (X: {0},Y: {1},Z: {2})", i.X, i.Y, i.Z);
            }
        }
    }
}