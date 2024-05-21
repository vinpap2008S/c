using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // 1
        string fileName = "mytest.txt";
        string content = "Привет и добро пожаловать\nЭто первый контент\nтекстового файла mytest.txt";

        File.WriteAllText(fileName, content);

        Console.WriteLine("Файл, созданный с именем содержимого " + fileName);

        // 2

        fileName = "mytest.txt";
        content = "Привет и добро пожаловать\nЭто первый контент\nтекстового файла mytest.txt";

        File.WriteAllText(fileName, content);

        Console.WriteLine("Вот содержимое файла " + fileName + ":");
        Console.WriteLine(File.ReadAllText(fileName));
        // 3

        Console.Write("Введите количество строк для записи в файл: ");
        int count = Convert.ToInt32(Console.ReadLine());

        string[] lines = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Строка ввода {i + 1}: ");
            lines[i] = Console.ReadLine();
        }

        File.WriteAllLines("file.txt", lines);

        Console.WriteLine("Файл успешно создан и заполнен.");

        // 4
        Console.Write("Введите строку, чтобы игнорировать строку: ");
        string ignoreString = Console.ReadLine();

        Console.Write("Введите количество строк для записи в файл: ");
        count = Convert.ToInt32(Console.ReadLine());

        lines = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Строка ввода {i + 1}: ");
            lines[i] = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter("file.txt"))
        {
            foreach (string line in lines)
            {
                if (!line.Contains(ignoreString))
                    writer.WriteLine(line);
            }
        }

        Console.WriteLine("Файл успешно создан и заполнен.");
        // 5 
        string filePath = "mytest.txt";

        Console.WriteLine("Вот содержимое файла mytest.txt:");
        Console.WriteLine("----------------------------------");
        PrintFileContent(filePath);

        Console.WriteLine("Введите текст для добавления в файл:");
        string textToAdd = Console.ReadLine();

        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine(textToAdd);
        }

        Console.WriteLine("Вот содержимое файла после добавления текста:");
        Console.WriteLine("----------------------------------");
        PrintFileContent(filePath);

        // 6
        string sourceFilePath = "mytest.txt";
        string destinationFilePath = "mynewtest.txt";

        Console.WriteLine("Вот содержимое файла mytest.txt:");
        Console.WriteLine("----------------------------------");
        PrintFileContent(sourceFilePath);

        File.Copy(sourceFilePath, destinationFilePath);

        Console.WriteLine("Файл mytest.txt успешно скопирован с именем mynewtest.txt в том же каталоге.");

        Console.WriteLine("Вот содержимое файла mynewtest.txt:");
        Console.WriteLine("----------------------------------");
        PrintFileContent(destinationFilePath);

        // 7

        sourceFilePath = "mytest.txt";
        destinationFilePath = "mynewtest.txt";

        File.WriteAllText(sourceFilePath, "Привет и добро пожаловать\nЭто первый контент\nтекстового файла mytest.txt");

        File.Move(sourceFilePath, destinationFilePath);

        Console.WriteLine($"Файл {sourceFilePath} успешно перемещен под именем {destinationFilePath} в том же каталоге.");

        Console.WriteLine($"Вот содержимое файла {sourceFilePath}:");
        Console.WriteLine(File.ReadAllText(destinationFilePath));

        Console.WriteLine($"Вот содержимое файла {destinationFilePath}:");
        Console.WriteLine(File.ReadAllText(destinationFilePath));

        // 8

        Console.Write("Введите количество строк для записи в файл: ");
        count = Convert.ToInt32(Console.ReadLine());

        lines = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Строка ввода {i + 1}: ");
            lines[i] = Console.ReadLine();
        }

        File.WriteAllLines("file.txt", lines);

        Console.WriteLine("Файл успешно создан и заполнен.");

        Console.WriteLine("Последние n строк файла:");
        int n = 3; // Число строк, которые нужно прочитать
        List<string> lastLines = ReadLastLines("file.txt", n);
        foreach (string line in lastLines)
        {
            Console.WriteLine(line);
        }
    }
    static void PrintFileContent(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    static List<string> ReadLastLines(string filePath, int n)
    {
        List<string> lines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            Queue<string> queue = new Queue<string>(n);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (queue.Count == n)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(line);
            }

            lines.AddRange(queue);
        }

        return lines;
    }
}

