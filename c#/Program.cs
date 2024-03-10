using System;

class Program
{
    static void Main()
    {
        // Задание 1
        DrawSquare(5, '*');

        // Задание 2
        Console.WriteLine(IsPalindrome(1221)); // true
        Console.WriteLine(IsPalindrome(3443)); // true
        Console.WriteLine(IsPalindrome(7854)); // false

        // Задание 3
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] result = FilterArray(originalArray, filterArray);
        Console.WriteLine(string.Join(" ", result)); // 1 2 -1
    }

    // Метод для рисования квадрата заданного символа
    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для проверки числа на палиндром
    static bool IsPalindrome(int number)
    {
        string numString = number.ToString();
        for (int i = 0; i < numString.Length / 2; i++)
        {
            if (numString[i] != numString[numString.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    // Метод для фильтрации массива на основе другого массива
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Where(num => !filterArray.Contains(num)).ToArray();
    }
}
