namespace ExercisePoint3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D startCoord = new Point3D(0, 0, 0);

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }

        public static Point3D ZeroCoord()
        {
            return startCoord;
        }
    }
}
