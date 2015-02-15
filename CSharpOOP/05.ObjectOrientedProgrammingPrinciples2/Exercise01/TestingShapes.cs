﻿namespace Exercise01
{
    //01.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
    //   Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of 
    //   the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable 
    //   constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() 
    //   method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
    //   (Circle, Rectangle, Triangle) stored in an array.

    using System;
    using System.Threading;
    using System.Globalization;

    class TestingShapes
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;// for problems with , and .

            Console.WriteLine("01.Testing shapes");

            var arrayOfShapes = new Shape [] 
            {
                new Triangle(5,10),
                new  Rectangle (5,5),
                new Circle (10)
            };

            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine("{0} with h= {1} and w= {2} , haves surface: {3}",shape.GetType().Name, shape.Height, shape.Width, shape.CalculateSurface());
            }
        }
    }
}
