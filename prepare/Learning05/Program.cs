using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Purple", 2);
        shapes.Add(shape1);

        Circle shape2 = new Circle("Green", 4);
        shapes.Add(shape2);

        Rectangle shape3 = new Rectangle("Orange", 2, 2.5);
        shapes.Add(shape3);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area} units.");

        }
    }
}
