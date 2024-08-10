using Practice_Polymorphism;
using System.ComponentModel;

Square square = new Square()
{
    Width = 10,
    Height = 10
};

Rectangle rectangle = new Rectangle()
{
    Width = 20,
    Height = 10
};

Triangle triangle = new Triangle()
{
    Width = 5,
    Height = 10
};

// Display the area of the square
square.DisplayArea();

// Display the area of the rectangle
rectangle.DisplayArea();

// Display the area of the triangle
triangle.DisplayArea();

