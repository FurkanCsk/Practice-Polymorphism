using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Polymorphism
{
    // Base class for geometric shapes
    public class GeometricShape
    {
        // Properties to store the dimensions of the shape
        public int Width { get; set; }
        public int Height { get; set; }

        // Virtual method to calculate the area of the shape
        public virtual double AreaCalc()
        {
            // Default area calculation (can be overridden by derived classes)
            return Width * Height;
        }

        // Virtual method to display the area of the shape
        public virtual void DisplayArea()
        {
            Console.WriteLine("Displaying area of the geometric shape");
        }
    }
    // Derived class for squares
    public class Square : GeometricShape
    {
        // Override method to calculate the area specifically for squares
        public override double AreaCalc()
        {
            // Square area calculation (width * width)
            return Width * Width;
        }

        // Override method to display the area of the square
        public override void DisplayArea()
        {
            Console.WriteLine($"Area of square : {AreaCalc()}");
        }
    }

    // Derived class for rectangles
    public class Rectangle : GeometricShape
    {
        // Override method to calculate the area specifically for rectangles
        public override double AreaCalc()
        {
            // Use the base class's area calculation method (width * height)
            return base.AreaCalc();
        }

        // Override method to display the area of the rectangle
        public override void DisplayArea()
        {
            Console.WriteLine($"Area of rectangle : {AreaCalc()}");
        }
    }

    // Derived class for triangles
    public class Triangle : GeometricShape
    {
        // Override method to calculate the area specifically for triangles
        public override double AreaCalc()
        {
            // Triangle area calculation (width * height / 2)
            return (Width * Height) / 2;
        }

        // Override method to display the area of the triangle
        public override void DisplayArea()
        {
            Console.WriteLine($"Area of Triangle : {AreaCalc()}");
        }
    }
}
