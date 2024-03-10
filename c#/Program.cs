using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
        int evenCount = array.Count(x => x % 2 == 0);
        int oddCount = array.Count(x => x % 2 != 0);
        int uniqueCount = array.Distinct().Count();
        Console.WriteLine($"Чётные: {evenCount}, Нечётные: {oddCount}, Уникальные: {uniqueCount}");

    //Задание 2
        int[] array = { 3, 5, 7, 2, 4, 6, 8 };
            int userInput = int.Parse(Console.ReadLine());
            int count = array.Count(x => x < userInput);
            Console.WriteLine($"Количество значений меньше {userInput}: {count}");

    // Задание 3
        int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int[] userInput = { 7, 6, 5 };
            int sequenceCount = Enumerable.Range(0, array.Length - userInput.Length + 1).Count(i => array.Skip(i).Take(userInput.Length).SequenceEqual(userInput));
            Console.WriteLine($"Количество повторений последовательности: {sequenceCount}");

    // Задание 4
        int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 3, 4, 5, 6 };
            var commonElements = array1.Intersect(array2).ToArray();
            Console.WriteLine($"Общие элементы без повторений: {string.Join(", ", commonElements)}");

    // Задание 5=
        int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int min = array.Cast<int>().Min();
            int max = array.Cast<int>().Max();
            Console.WriteLine($"Минимальное значение: {min}, Максимальное значение: {max}");

    // Задание 6
    string sentence = Console.ReadLine();
            int wordCount = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Количество слов в предложении: {wordCount}");

    // Задание 7
        string sentence = Console.ReadLine();
            string reversedSentence = string.Join(" ", sentence.Split(' ').Select(word => new string(word.Reverse().ToArray())));
            Console.WriteLine($"После переворота: {reversedSentence}");
    // Задание 8
        string sentence = Console.ReadLine();
            int vowelCount = sentence.Count(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine($"Количество гласных букв: {vowelCount}");

    // Задание 9
        string originalString = "Why she had to go. I don't know, she wouldn't say";
            string substringToSearch = "she";
            int occurrences = originalString.Split(new string[] { substringToSearch }, StringSplitOptions.None).Length - 1;
            Console.WriteLine($"Результат поиска: {occurrences}");
        }
}
