using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";
        int totalCharsCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                int charCode = reader.Read();
                if (charCode != -1)
                {
                    char character = (char)charCode;
                    Console.WriteLine($"{character}: {charCode}");
                    totalCharsCount++;
                }
            }
        }

        Console.WriteLine($"Общее количество символов: {totalCharsCount}");

        
        int wordCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string text = reader.ReadToEnd();
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount = words.Length;
        }

        Console.WriteLine($"Общее количество слов в файле: {wordCount}");

        int lineCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }

        Console.WriteLine($"Общее количество строк в файле: {lineCount}");

        int wordCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }

        Console.WriteLine($"Общее количество слов в файле: {wordCount}");
    }
}
