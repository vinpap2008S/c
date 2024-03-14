using System;

class Животное
{
    public string Имя { get; set; }

    public Животное(string имя)
    {
        Имя = имя;
    }
}

class Тигр : Животное
{
    public string Раса { get; set; }

    public Тигр(string имя, string раса) : base(имя)
    {
        Раса = раса;
    }

    public void Охотиться()
    {
        Console.WriteLine($"Тигр {Имя} охотится на добычу.");
    }
}

class Крокодил : Животное
{
    public int ДлинаХвоста { get; set; }

    public Крокодил(string имя, int длинаХвоста) : base(имя)
    {
        ДлинаХвоста = длинаХвоста;
    }

    public void Плавать()
    {
        Console.WriteLine($"Крокодил {Имя} плавает в воде.");
    }
}

class Кенгуру : Животное
{
    public int ДлинаПрыжка { get; set; }

    public Кенгуру(string имя, int длинаПрыжка) : base(имя)
    {
        ДлинаПрыжка = длинаПрыжка;
    }

    public void Прыгать()
    {
        Console.WriteLine($"Кенгуру {Имя} прыгает на расстояние {ДлинаПрыжка} метров.");
    }
}

class Program
{
    static Func<double, double> КвадратичныйТрехчлен(double a, double b, double c)
    {
        return x => a * x * x + b * x + c;
    }
    static void Main()
    {

        Тигр тигр = new Тигр("Шерхан", "Бенгальский");
        тигр.Охотиться();

        Крокодил крокодил = new Крокодил("Гена", 3);
        крокодил.Плавать();

        Кенгуру кенгуру = new Кенгуру("Кенни", 10);
        кенгуру.Прыгать();
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        double a = 1, b = 2, c = 3;
        var функция = КвадратичныйТрехчлен(a, b, c);

        double x = 5;
        double результат = функция(x);

        Console.WriteLine($"Значение квадратичного трехчлена при x={x}: {результат}");
    }
}