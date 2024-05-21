using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // 1
        string fileName = "Day17.txt";

        Console.WriteLine("Меню:");
        Console.WriteLine("1. Создать новый файл и записать информацию");
        Console.WriteLine("2. Открыть и прочитать файл");
        Console.Write("Выберите действие (1 или 2): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateAndWriteToFile(fileName);
                break;
            case "2":
                ReadAndProcessFile(fileName);
                break;
            default:
                Console.WriteLine("Некорректный выбор.");
                break;
        }

        // 2
        string inputFileName = "input.txt";
        string outputFileName = "OutputCode.cs";

        if (!File.Exists(inputFileName))
        {
            Console.WriteLine("Файл с исходным кодом не найден.");
            return;
        }

        string code = File.ReadAllText(inputFileName);

        // Замена слов public на private и преобразование символов
        code = code.Replace("public", "private");
        code = TransformCode(code);

        // Запись символов каждой строки в обратном порядке
        string reversedCode = ReverseLines(code);

        File.WriteAllText(outputFileName, reversedCode);
        Console.WriteLine("Программа успешно обработана. Результат записан в файл 'OutputCode.cs'.");

        // 3
        fileName = "mytest.txt";
        string content = "Привет и добро пожаловать\nЭто первый контент\nтекстового файла mytest.txt";

        File.WriteAllText(fileName, content);

        Console.WriteLine("Файл, созданный с именем содержимого " + fileName);

        // 4

        fileName = "mytest.txt";
        fileName = "Привет и добро пожаловать\nЭто первый контент\nтекстового файла mytest.txt";

        File.WriteAllText(fileName, content);

        Console.WriteLine("Вот содержимое файла " + fileName + ":");
        Console.WriteLine(File.ReadAllText(fileName));

    }
    static void CreateAndWriteToFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine("Файл с именем 'Day17.txt' уже существует.");
            return;
        }

        double[,] doubleArray = { { 1.1, 2.2 }, { 3.3, 4.4 } };
        int[,] intArray = { { 1, 2 }, { 3, 4 } };
        string personalInfo = "Иванов Иван Иванович, 01.01.2000";

        string formattedInfo = $"Исходные данные: двумерный массив дробных чисел.\n{doubleArray.GetLength(0)} {doubleArray.GetLength(1)}";
        foreach (var item in doubleArray)
        {
            formattedInfo += $"\n{item}";
        }
        formattedInfo += $"\n{intArray.GetLength(0)} {intArray.GetLength(1)}";
        foreach (var item in intArray)
        {
            formattedInfo += $" {item}";
        }
        formattedInfo += $"\n{personalInfo}\nДата: {DateTime.Now}";

        File.WriteAllText(fileName, formattedInfo);
        Console.WriteLine($"Информация успешно записана в файл '{fileName}'.");
    }
    static void ReadAndProcessFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Файл 'Day17.txt' не найден.");
            return;
        }

        string fileContent = File.ReadAllText(fileName);
        Console.WriteLine("\nСодержимое файла 'Day17.txt':");
        Console.WriteLine(fileContent);

    }
    static string TransformCode(string code)
    {
        StringBuilder sb = new StringBuilder();

        bool inWord = false;
        foreach (char c in code)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    inWord = true;
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            else
            {
                inWord = false;
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
    static string ReverseLines(string code)
    {
        string[] lines = code.Split('\n');
        Array.Reverse(lines);
        return string.Join("", lines);
    }
}
