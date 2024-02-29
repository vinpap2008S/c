using System;

class Program
{
    static void Main()
    {
        // Задача 1
        Console.WriteLine("Введите число от 1 до 100:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100.");
        }
        else
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        // Задача 2
        Console.WriteLine("Введите два числа:");
        double value = Convert.ToDouble(Console.ReadLine());
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (percent / 100) * value;
        Console.WriteLine($"Результат: {percent}% от {value} = {result}");

        // Задача 3
        Console.WriteLine("Введите четыре цифры:");
        string input = Console.ReadLine();

        if (input.Length != 4)
        {
            Console.WriteLine("Ошибка! Необходимо ввести четыре цифры.");
            return;
        }

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Сформированное число: {number}");
        }
        else
        {
            Console.WriteLine("Ошибка! Введите только цифры.");
        }

        // Задача 4
        Console.WriteLine("Введите шестизначное число:");
        string inputNumber = Console.ReadLine();

        if (inputNumber.Length != 6 || !int.TryParse(inputNumber, out _))
        {
            Console.WriteLine("Ошибка! Введите шестизначное число.");
            return;
        }

        Console.WriteLine("Введите номера разрядов для обмена (например, 1 и 6):");
        string inputPositions = Console.ReadLine();
        string[] positions = inputPositions.Split(' ');

        if (positions.Length != 2 || !int.TryParse(positions[0], out int position1) || !int.TryParse(positions[1], out int position2))
        {
            Console.WriteLine("Ошибка! Введите два номера разрядов для обмена.");
            return;
        }

        char[] numberArray = inputNumber.ToCharArray();
        char temp = numberArray[position1 - 1];
        numberArray[position1 - 1] = numberArray[position2 - 1];
        numberArray[position2 - 1] = temp;

        string resultNumber = new string(numberArray);
        Console.WriteLine($"Измененное число: {resultNumber}");

        // Задача 5
        Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
        string inputDate = Console.ReadLine();

        if (DateTime.TryParse(inputDate, out DateTime date))
        {
            string season = GetSeason(date.Month);
            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Ошибка! Некорректный формат даты.");
        }

        // Задача 6
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Перевести из Фаренгейта в Цельсий");
        Console.WriteLine("2. Перевести из Цельсия в Фаренгейт");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Введите температуру в градусах Фаренгейта:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Температура в Цельсиях: {celsius}");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Введите температуру в градусах Цельсия:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
        }
        //Задача 7
        Console.WriteLine("Введите два числа для определения диапазона:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int start, end;

        if (num1 < num2)
        {
            start = num1;
            end = num2;
        }
        else
        {
            start = num2;
            end = num1;
        }

        Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }

    static string GetSeason(int month)
    {
        if (month == 12 || month <= 2)
        {
            return "Winter";
        }
        else if (month >= 3 && month <= 5)
        {
            return "Spring";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Summer";
        }
        else
        {
            return "Autumn";
        }
    }

}