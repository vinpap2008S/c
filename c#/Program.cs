using System;
using System.Collections.Generic;
using System.Xml.Linq;


abstract class Издание
{
    public string Название { get; set; }
    public string ФамилияАвтора { get; set; }

    public abstract void ПоказатьИнформацию();
    public abstract bool ПроверитьИскомое(string искомаяФамилия);
}

class Книга : Издание
{
    public int ГодИздания { get; set; }
    public string Издательство { get; set; }

    public override void ПоказатьИнформацию()
    {
        Console.WriteLine($"Книга: {Название}, Автор: {ФамилияАвтора}, Год издания: {ГодИздания}, Издательство: {Издательство}");
    }

    public override bool ПроверитьИскомое(string искомаяФамилия)
    {
        return ФамилияАвтора == искомаяФамилия;
    }
}

class Статья : Издание
{
    public string НазваниеЖурнала { get; set; }
    public int НомерЖурнала { get; set; }
    public int ГодИздания { get; set; }

    public override void ПоказатьИнформацию()
    {
        Console.WriteLine($"Статья: {Название}, Автор: {ФамилияАвтора}, Журнал: {НазваниеЖурнала}, Номер: {НомерЖурнала}, Год издания: {ГодИздания}");
    }

    public override bool ПроверитьИскомое(string искомаяФамилия)
    {
        return ФамилияАвтора == искомаяФамилия;
    }
}

class ЭлектронныйРесурс : Издание
{
    public string Ссылка { get; set; }
    public string Аннотация { get; set; }

    public override void ПоказатьИнформацию()
    {
        Console.WriteLine($"Электронный ресурс: {Название}, Автор: {ФамилияАвтора}, Ссылка: {Ссылка}, Аннотация: {Аннотация}");
    }

    public override bool ПроверитьИскомое(string искомаяФамилия)
    {
        return ФамилияАвтора == искомаяФамилия;
    }
}

abstract class BaseArray
{
    protected int[] array;

    public BaseArray(int size)
    {
        array = new int[size];
    }

    public int Size => array.Length;

    public abstract void DisplayArray();

    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}

class DerivedArray : BaseArray
{
    public DerivedArray(int size) : base(size)
    {
    }

    public override void DisplayArray()
    {
        Console.Write("Array elements: ");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;

abstract class Figure : IComparable<Figure>
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract void DisplayInfo();

    public int CompareTo(Figure other)
    {
        return this.CalculateArea().CompareTo(other.CalculateArea());
    }
}

class Rectangle : Figure
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return width * height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Rectangle - Width: {0}, Height: {1}, Area: {2}, Perimeter: {3}",
            width, height, CalculateArea(), CalculatePerimeter());
    }
}

class Circle : Figure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Circle - Radius: {0}, Area: {1}, Perimeter: {2}",
            radius, CalculateArea(), CalculatePerimeter());
    }
}

class Triangle : Figure
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double CalculateArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    public override double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Triangle - Side A: {0}, Side B: {1}, Side C: {2}, Area: {3}, Perimeter: {4}",
            sideA, sideB, sideC, CalculateArea(), CalculatePerimeter());
    }
}
class Program
{
    static void Main()
    {
        Console.Write("1 Задание");
        Издание[] каталог = {
            new Книга { Название = "Война и мир", ФамилияАвтора = "Толстой", ГодИздания = 1869, Издательство = "Издательство1" },
            new Статья { Название = "Название статьи", ФамилияАвтора = "Автор статьи", НазваниеЖурнала = "Журнал1", НомерЖурнала = 1, ГодИздания = 2021 },
            new ЭлектронныйРесурс { Название = "Название ресурса", ФамилияАвтора = "Автор ресурса", Ссылка = "ссылка1", Аннотация = "Аннотация1" }
        };

        foreach (var издание in каталог)
        {
            издание.ПоказатьИнформацию();
        }

        string искомаяФамилия = "Толстой";
        foreach (var издание in каталог)
        {
            if (издание.ПроверитьИскомое(искомаяФамилия))
            {
                Console.WriteLine($"Издание найдено: {издание.Название}");
            }
        }
        Console.Write("2 Задание");
        DerivedArray derivedArray = new DerivedArray(5);

        for (int i = 0; i < derivedArray.Size; i++)
        {
            derivedArray[i] = i * 10;
        }

        derivedArray.DisplayArray();


        Console.WriteLine("Element at index 2: " + derivedArray[2]);
        derivedArray[2] = 100;
        Console.WriteLine("Element at index 2 after update: " + derivedArray[2]);
        Console.Write("3 Задание");
        List<Figure> figures = new List<Figure>
        {
            new Rectangle(5, 10),
            new Circle(3),
            new Triangle(3, 4, 5)
        };

        figures.Sort();

        foreach (var figure in figures)
        {
            figure.DisplayInfo();
        }
    }
}

