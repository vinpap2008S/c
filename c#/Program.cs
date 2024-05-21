using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PurchasePrice { get; set; }
}

class Purchase
{
    public int Id { get; set; }
    public int Quantity { get; set; }
}



class Program
{
    static void cityView(string cityMetro)
    {
        Console.WriteLine(cityMetro);
        Console.WriteLine("-- here is a group of cities --\n");
    }
    static void Main()
    {
        // 1 Задание
        List<int> numbers = new List<int> { 5, 9, 13, 24, 2, 7, 19 };

        Console.Write("Сколько записей вы хотите отобразить? : ");
        int n = int.Parse(Console.ReadLine());

        var topN = numbers.OrderByDescending(num => num).Take(n);

        Console.WriteLine("Лучшие {0} записи из списка:", n);
        foreach (var number in topN)
        {
            Console.WriteLine(number);
        }

        // 2 
        string inputString = "Это Пример строки Для Поиска ПРОПИСНЫХ слов 123";

        var uppercaseWords = inputString.Split(' ').Where(word => !string.IsNullOrEmpty(word) && word.All(char.IsLower));

        Console.WriteLine("Прописные слова в строке:");
        foreach (var word in uppercaseWords)
        {
            Console.WriteLine(word);
        }

        // 3 

        string[] str = {"cat", "dog", "uy"};

        inputString = string.Join(", ", str); ;
        Console.WriteLine(inputString);

        // 4

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Score = 800 },
            new Student { Id = 2, Name = "Bob", Score = 700 },
            new Student { Id = 3, Name = "Charlie", Score = 600 },
            new Student { Id = 4, Name = "David", Score = 750 },
            new Student { Id = 5, Name = "Eve", Score = 700 },
            new Student { Id = 6, Name = "Frank", Score = 650 },
            new Student { Id = 7, Name = "David", Score = 750 },
            new Student { Id = 8, Name = "Grace", Score = 720 },
            new Student { Id = 9, Name = "Harry", Score = 680 },
            new Student { Id = 10, Name = "Jenny", Score = 750 }
        };

        Console.Write("Какой максимальный балл (1, 2, 3, ...) вы хотите найти: ");
        n = Convert.ToInt32(Console.ReadLine());

        var distinctScores = students.Select(s => s.Score).Distinct().OrderByDescending(score => score).ToList();

        if (n <= distinctScores.Count)
        {
            int nthMaxScore = distinctScores[n - 1];
            var studentWithNthMaxScore = students.FirstOrDefault(s => s.Score == nthMaxScore);

            if (studentWithNthMaxScore != null)
            {
                Console.WriteLine($"Идентификатор: {studentWithNthMaxScore.Id}, Имя: {studentWithNthMaxScore.Name}, достигнут балл: {studentWithNthMaxScore.Score}");
            }
            else
            {
                Console.WriteLine("Студент не найден.");
            }
        }
        else
        {
            Console.WriteLine("Такого максимального балла нет в списке.");
        }

        // 5

        string[] files = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

        var fileExtensions = files
            .Select(file => System.IO.Path.GetExtension(file).ToLower()) 
            .GroupBy(extension => extension)
            .OrderBy(group => group.Key);

        Console.WriteLine("Вот группа расширений файлов:");
        foreach (var group in fileExtensions)
        {
            string pluralSuffix = group.Count() == 1 ? "" : "ов";
            Console.WriteLine("{0} файл{1} с расширением {2}", group.Count(), pluralSuffix, group.Key);
        }

        // 6

        int[] files_average = {125,34,70,9};

        var averageSize = files_average.Average();

        Console.WriteLine(averageSize);

        // 7

        List<string> fruits = new List<string> { "apple", "banana", "orange", "grape" };

        fruits.Remove("banana");
        
        Console.WriteLine("Список фруктов после удаления:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 8

        fruits = new List<string> { "apple", "banana", "orange", "grape" };

        fruits = fruits.Where(fruit => !fruit.Contains('a')).ToList();

        Console.WriteLine("Список фруктов после удаления:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 9

        fruits = new List<string> { "apple", "banana", "orange", "grape" };

        fruits.RemoveAll(fruit => fruit.Contains('a'));

        Console.WriteLine("Список фруктов после удаления:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 10

        fruits = new List<string> { "apple", "banana", "orange", "grape" };

        fruits.RemoveAt(1);

        Console.WriteLine("Список фруктов после удаления:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 11

        fruits = new List<string> { "apple", "banana", "orange", "grape" };

        fruits.RemoveRange(1, 2);

        Console.WriteLine("Список фруктов после удаления:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //12 

        fruits = new List<string> { "apple", "banana", "orange", "grape" };

        int minLength = 6;

        List<string> filteredStrings = fruits.FindAll(str => str.Length >= minLength);

        Console.WriteLine("Строки минимальной длины {0}:", minLength);
        foreach (var fruit in filteredStrings)
        {
            Console.WriteLine(fruit);
        }

        //13

        List<char> letterList = new List<char> { 'X' };
        List<int> numberList = new List<int> { 1, 2, 3, 4 };

        var cartesianProduct = from letter in letterList
                               from number in numberList
                               select new { letterList = letter, numberList = number };

        Console.WriteLine("Декартово произведение:");
        foreach (var item in cartesianProduct)
        {
            Console.WriteLine($"{{letterList = {item.letterList}, numberList = {item.numberList}}}");
        }

        //14 

        letterList = new List<char> { 'X', 'Y' };
        numberList = new List<int> { 1, 2, 3 };
        List<string> colorList = new List<string> { "зеленый", "оранжевый" };

        var cartesianProduct_1 = from letter in letterList
                           from number in numberList
                           from color in colorList
                           select new { letterList = letter, numberList = number, colorList = color };

        Console.WriteLine("Декартовы произведения:");
        foreach (var item in cartesianProduct_1)
        {
            Console.WriteLine($"{{буква = {item.letterList}, число = {item.numberList}, цвет = {item.colorList}}}");
        }

        //15

        List<Product> productList = new List<Product>
        {
            new Product { Id = 1, Name = "печенье", PurchasePrice = 458 },
            new Product { Id = 2, Name = "Шоколад", PurchasePrice = 650 },
            new Product { Id = 3, Name = "масла", PurchasePrice = 800 },
            new Product { Id = 3, Name = "масла", PurchasePrice = 900 },
            new Product { Id = 3, Name = "масла", PurchasePrice = 900 },
            new Product { Id = 4, Name = "Brade", PurchasePrice = 700 },
            new Product { Id = 4, Name = "Brade", PurchasePrice = 650 }
        };

        List<Purchase> purchaseList = new List<Purchase>
        {
            new Purchase { Id = 1, Quantity = 10 },
            new Purchase { Id = 2, Quantity = 5 },
            new Purchase { Id = 3, Quantity = 2 },
            new Purchase { Id = 4, Quantity = 3 }
        };

        var innerJoinQuery = from product in productList
                             join purchase in purchaseList on product.Id equals purchase.Id
                             select new { ProductId = product.Id, ProductName = product.Name, Purchase = purchase.Quantity };

        Console.WriteLine("Идентификатор товара\tНазвание товара\tПокупка Количество");
        Console.WriteLine("-------------------------------------------------- -----");

        foreach (var item in innerJoinQuery)
        {
            Console.WriteLine($"{item.ProductId}\t\t\t{item.ProductName}\t\t{item.Purchase}");
        }

        //16

        productList.Add(new Product { Id = 5, Name = "мед", PurchasePrice = 0 });

        var leftJoinQuery = from product in productList
                            join purchase in purchaseList on product.Id equals purchase.Id into gj
                            from subpurchase in gj.DefaultIfEmpty(new Purchase { Id = product.Id, Quantity = 0 })
                            select new { ProductId = product.Id, ProductName = product.Name, Purchase = subpurchase.Quantity };

        Console.WriteLine("Идентификатор товара\tНазвание товара\tПокупка Количество");
        Console.WriteLine("-------------------------------------------------- -----");

        foreach (var item in leftJoinQuery)
        {
            Console.WriteLine($"{item.ProductId}\t\t\t{item.ProductName}\t\t{item.Purchase}");
        }

        // 18

        string[] cities1 =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

        Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
        Console.Write("\n--------------------------------------------------------------------------------\n");
        Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
        Console.Write("\nHere is the arranged list :\n");
        IEnumerable<string> cityOrder =
        cities1.OrderBy(str => str.Length)
                        .ThenBy(str => str);
        foreach (string city in cityOrder)
            Console.WriteLine(city);
        

        // 19

        string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

        Console.Write("\nLINQ : Split a collection of strings into some groups  : ");
        Console.Write("\n-------------------------------------------------------\n");
        Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI', \n");
        Console.Write("                   'AMSTERDAM','ABU DHABI','PARIS','NEW YORK' \n");
        Console.Write("\nHere is the group of cities : \n\n");
        var citySplit = from i in Enumerable.Range(0, cities.Length)
                        group cities[i] by i / 3;
        foreach (var city in citySplit)
            cityView(string.Join(";  ", city.ToArray()));
        // 20

        numbers = new List<int> { 5, 2, 8, 1, 9, 3 };

        Console.WriteLine("Исходный список:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        numbers.Sort();

        Console.WriteLine("\nСписок после сортировки в порядке возрастания:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

    }
}
