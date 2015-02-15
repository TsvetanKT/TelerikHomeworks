namespace ExercisePoint3D
{
    using System;
    using System.Linq;

    class TestPoints3DLoadAndSave
    {
        //01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D
        //   space. Implement the ToString() to enable printing a 3D point.
        //02.Add a private static read-only field to hold the start of the coordinate system
        //   – the point O{0, 0, 0}. Add a static property to return the point O.
        //03.Write a static class with a static method to calculate the distance between two 
        //   points in the 3D space.
        //04.Create a class Path to hold a sequence of points in the 3D space. Create a static 
        //   class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
        static void Main()
        {
            //Initialize the path
            Path p = new Path();
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(4, 5, 6));
            p.AddPoint(new Point3D(20, 30, 40));
            p.AddPoint(new Point3D(-7, -8, -9));
            p.AddPoint(new Point3D(-11, 0, 5));
        
            PathStorage.SavePath(p); //Saving the path in file PathsDatabase.txt
            Path final = PathStorage.LoadPath(); //Loading the path from the file PathsDatabase.txt

            Console.WriteLine("Start of the coordinate system: " + Point3D.ZeroCoord());//Printing zero point's coordinates
            final.PrintPathList(); //Printing the path

            Console.WriteLine();
            Point3D first = new Point3D(1, 1, 1);
            Point3D second = new Point3D(2, 2, 2);
            //Printing the distance between some two points
            Console.WriteLine("Distance: {0}", Distance3D.CalculateDistance(first, second));

        }
    }
}