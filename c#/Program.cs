using System;
using System.Linq;

struct ArrayStructure
{
    private int[] array;

    public ArrayStructure(int size)
    {
        array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101); // случайные числа от 1 до 100
        }
    }

    public int GetMaxElement()
    {
        return array.Max();
    }

    public int GetMinElement()
    {
        return array.Min();
    }

    public double GetAverage()
    {
        return array.Average();
    }
}

struct TextStructure
{
    public string text;

    public CharStructure GetCharAtIndex(int index)
    {
        char character = text.Length > index ? text[index] : ' ';
        return new CharStructure() { character = character };
    }
}

struct CharStructure
{
    public char character;
}

struct FirstStructure
{
    public int num;
}

struct SecondStructure
{
    public int num1;
    public int num2;

    public FirstStructure[] GetArrayOfFirstStructs()
    {
        return new FirstStructure[] { new FirstStructure() { num = num1 }, new FirstStructure() { num = num2 } };
    }
}

class Program
{
    static void Main()
    {
        // Задание 1
        ArrayStructure arrayStruct = new ArrayStructure(5);
        Console.WriteLine("Массив:");
        foreach (int num in arrayStruct.array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Наибольший элемент в массиве: " + arrayStruct.GetMaxElement());
        Console.WriteLine("Наименьший элемент в массиве: " + arrayStruct.GetMinElement());
        Console.WriteLine("Среднее значение элементов в массиве: " + arrayStruct.GetAverage());

        // Задание 2
        TextStructure textStruct = new TextStructure() { text = "Hello" };
        CharStructure charResult = textStruct.GetCharAtIndex(2);
        Console.WriteLine("Символ по индексу 2 в тексте: " + charResult.character);

        // Задание 3
        FirstStructure firstStruct1 = new FirstStructure() { num = 5 };
        FirstStructure firstStruct2 = new FirstStructure() { num = 10 };
        SecondStructure resultStruct = new SecondStructure() { num1 = firstStruct1.num + firstStruct2.num, num2 = firstStruct1.num + firstStruct2.num };
        Console.WriteLine("Сумма двух экземпляров первой структуры: " + resultStruct.num1 + " " + resultStruct.num2);
        FirstStructure[] arrayOfFirstStructs = resultStruct.GetArrayOfFirstStructs();
        Console.WriteLine("Массив из двух экземпляров первой структуры: " + arrayOfFirstStructs[0].num + " " + arrayOfFirstStructs[1].num);
    }
}
