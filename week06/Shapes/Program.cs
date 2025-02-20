using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Red",5);

        Rectangle rectangle = new Rectangle("Blue",10,5);

        Circle circle = new Circle("White",4);

        // DisplayShapeInformation(square);    
        // DisplayShapeInformation(rectangle);    
        // DisplayShapeInformation(circle);    

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shap in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = shap.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = shap.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
    }

    public static void DisplayShapeInformation(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"The {shape.GetColor()} shape has an area of {area}");
    }
}