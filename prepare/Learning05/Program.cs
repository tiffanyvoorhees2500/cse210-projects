using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("red", 4);
        shapes.Add(square1);

        Circle circle1 = new Circle("blue",2);
        shapes.Add(circle1);

        Rectangle rectangle1 = new Rectangle("yellow",3,2);
        shapes.Add(rectangle1);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}