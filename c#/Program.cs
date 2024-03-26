using System;

public abstract class Shape
{
    public ConsoleColor Color { get; set; }
    public int Size { get; set; }

    public abstract void Draw(int x, int y);
}
public class Triangle : Shape
{
    public override void Draw(int x, int y)
    {
        Console.ForegroundColor = Color;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

public class Circle : Shape
{
    public override void Draw(int x, int y)
    {
        Console.ForegroundColor = Color;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Math.Sqrt((i - Size / 2) * (i - Size / 2) + (j - Size / 2) * (j - Size / 2)) <= Size / 2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
public class Rectangle : Shape
{
    public override void Draw(int x, int y)
    {
        Console.ForegroundColor = Color;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}




public class ShapeCollection
{
    private List<Shape> shapes = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void DrawAllShapes()
    {
        foreach (var shape in shapes)
        {
            shape.Draw(0, 0);
        }
    }
}

class Program
{
    static void Main()
    {
        ShapeCollection collection = new ShapeCollection();

        Rectangle rectangle = new Rectangle { Color = ConsoleColor.Yellow, Size = 5 };
        collection.AddShape(rectangle);

        Triangle triangle = new Triangle { Color = ConsoleColor.Green, Size = 5 };
        collection.AddShape(triangle);

        Circle circle = new Circle { Color = ConsoleColor.Red, Size = 100 };
        collection.AddShape(circle);

        collection.DrawAllShapes();
    }
}
