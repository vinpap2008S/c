using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Привет, меня зовут {Name} и мне {Age} лет.");
    }
}

class Builder : Human
{
    public string Specialization { get; set; }

    public void Build()
    {
        Console.WriteLine($"Я строитель по специализации {Specialization}.");
    }
}

class Sailor : Human
{
    public string ShipName { get; set; }

    public void Sail()
    {
        Console.WriteLine($"Я моряк на корабле {ShipName}.");
    }
}

class Pilot : Human
{
    public string AircraftModel { get; set; }

    public void Fly()
    {
        Console.WriteLine($"Я летчик на самолете {AircraftModel}.");
    }
}

class Program
{
    static void Main()
    {
        Builder builder = new Builder { Name = "Иван", Age = 35, Specialization = "строитель высотных зданий" };
        builder.Introduce();
        builder.Build();

        Sailor sailor = new Sailor { Name = "Петр", Age = 40, ShipName = "Ласточка" };
        sailor.Introduce();
        sailor.Sail();

        Pilot pilot = new Pilot { Name = "Алексей", Age = 30, AircraftModel = "Boeing 737" };
        pilot.Introduce();
        pilot.Fly();
    }
}

class Passport
{
    public string FullName { get; set; }
    public string PassportNumber { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Паспорт: {PassportNumber}, ФИО: {FullName}");
    }
}

class ForeignPassport : Passport
{
    public string Country { get; set; }
    public string VisaInfo { get; set; }

    public void DisplayForeignInfo()
    {
        Console.WriteLine($"Заграничный паспорт: {PassportNumber}, ФИО: {FullName}, Страна: {Country}, Виза: {VisaInfo}");
    }
}

class Program
{
    static void Main()
    {
        Passport passport = new Passport { FullName = "Иванов Иван Иванович", PassportNumber = "123456789" };
        passport.DisplayInfo();

        ForeignPassport foreignPassport = new ForeignPassport { FullName = "Smith John", PassportNumber = "987654321", Country = "USA", VisaInfo = "Valid until 2023" };
        foreignPassport.DisplayForeignInfo();
    }
}
