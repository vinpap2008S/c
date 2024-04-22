// Задание № 1
using System;
using System.Collections.Generic;

class Translator
{
    private Dictionary<string, string> engToRus = new Dictionary<string, string>();
    private Dictionary<string, string> rusToEng = new Dictionary<string, string>();

    public void AddTranslation(string eng, string rus)
    {
        engToRus[eng] = rus;
        rusToEng[rus] = eng;
    }

    public string Translate(string word, bool isEngToRus)
    {
        if (isEngToRus && engToRus.ContainsKey(word))
        {
            return engToRus[word];
        }
        else if (!isEngToRus && rusToEng.ContainsKey(word))
        {
            return rusToEng[word];
        }
        return "Translation not found";
    }
}

// Задание № 2
class Point2D<T>
{
    public T X { get; set; }
    public T Y { get; set; }

    public Point2D(T x, T y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Point3D : Point2D<int>
{
    public int Z { get; set; }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
}

// Задание № 3
class Line<T>
{
    private Point2D<T> point1;
    private Point2D<T> point2;

    public Line(Point2D<T> p1, Point2D<T> p2)
    {
        point1 = p1;
        point2 = p2;
    }

    public Line(T x1, T y1, T x2, T y2)
    {
        point1 = new Point2D<T>(x1, y1);
        point2 = new Point2D<T>(x2, y2);
    }

    public override string ToString()
    {
        return $"Line from {point1} to {point2}";
    }
}

class Program
{
    static void Main()
    {
        // Задание № 1
        Translator translator = new Translator();
        translator.AddTranslation("Russia", "Россия");
        translator.AddTranslation("USA", "США");

        Console.WriteLine(translator.Translate("Russia", true));
        Console.WriteLine(translator.Translate("США", false));

        // Задание № 2
        Point3D point3D = new Point3D(1, 2, 3);
        Console.WriteLine(point3D);

        // Задание № 3
        Line<int> line = new Line<int>(0, 0, 1, 1);
        Console.WriteLine(line);
    }
}
