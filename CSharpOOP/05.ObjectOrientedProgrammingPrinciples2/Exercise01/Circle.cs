namespace Exercise01
{
    using System;
    class Circle : Shape
    {
        public Circle (double diameter)
            :base(diameter,diameter)
        // The width and the height of a circle are equal and =2 times his radius -> his diameter
        {
            // An empty constructor
        }

        public override double CalculateSurface()
        {
            // The constructor makes height = width = the diameter of the circle
            // so "Math.PI*(this.Height/2) * (this.Width/2)"== pi * r * r 
            return Math.PI*(this.Height/2) * (this.Width/2);         
        }
    }
}
