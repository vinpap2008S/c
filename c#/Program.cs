using System;

class Passport
{
    public string PassportNumber { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfIssue { get; set; }

    public Passport(string passportNumber, string fullName, DateTime dateOfIssue)
    {
        if (string.IsNullOrWhiteSpace(passportNumber) || string.IsNullOrWhiteSpace(fullName) || dateOfIssue == DateTime.MinValue)
        {
            throw new ArgumentException("Неверные данные для инициализации паспорта.");
        }

        PassportNumber = passportNumber;
        FullName = fullName;
        DateOfIssue = dateOfIssue;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Passport passport = new Passport("123456789", "Иванов Иван Иванович", new DateTime(2021, 12, 15));
            Console.WriteLine("Паспорт успешно создан.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка при создании паспорта: " + ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите направление перевода:");
        Console.WriteLine("1. Из десятичной в двоичную");
        Console.WriteLine("2. Из двоичной в десятичную");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
        {
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("Введите число в десятичной системе:");
                if (int.TryParse(Console.ReadLine(), out int decimalNumber))
                {
                    string binaryNumber = Convert.ToString(decimalNumber, 2);
                    Console.WriteLine($"Число {decimalNumber} в двоичной системе: {binaryNumber}");
                }
                else
                {
                    Console.WriteLine("Ошибка! Некорректный ввод числа.");
                }
                break;
            case 2:
                Console.WriteLine("Введите число в двоичной системе:");
                string binaryInput = Console.ReadLine();
                if (int.TryParse(binaryInput, System.Globalization.NumberStyles.AllowBinarySpecifier, null, out int result))
                {
                    Console.WriteLine($"Число {binaryInput} в десятичной системе: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка! Некорректный ввод числа в двоичной системе.");
                }
                break;
        }
        Console.WriteLine("Введите слово от zero до nine:");
        string inputWord = Console.ReadLine().ToLower();

        switch (inputWord)
        {
            case "zero":
                Console.WriteLine("0");
                break;
            case "one":
                Console.WriteLine("1");
                break;
            case "two":
                Console.WriteLine("2");
                break;
            case "three":
                Console.WriteLine("3");
                break;
            case "four":
                Console.WriteLine("4");
                break;
            case "five":
                Console.WriteLine("5");
                break;
            case "six":
                Console.WriteLine("6");
                break;
            case "seven":
                Console.WriteLine("7");
                break;
            case "eight":
                Console.WriteLine("8");
                break;
            case "nine":
                Console.WriteLine("9");
                break;
            default:
                Console.WriteLine("Некорректное слово. Введите слово от zero до nine.");
                break;
        }
    }
}
