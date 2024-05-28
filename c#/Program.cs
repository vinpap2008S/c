using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ClassLib;

namespace SerializDeserializExample
{
    class Program
    {
        static void Main()
        {
            // Создаем список объектов PC
            List<PC> pcs = new List<PC>
            {
                new PC("Dell", "12345"),
                new PC("HP", "67890"),
                new PC("Lenovo", "54321"),
                new PC("Acer", "09876"),
                new PC("Asus", "13579")
            };

            // Путь к файлу сериализации
            string filePath = @"C:\path\to\file.json";

            // Сериализация списка в формат JSON и сохранение в файл
            string json = JsonSerializer.Serialize(pcs);
            File.WriteAllText(filePath, json);

            Console.WriteLine("Сериализация выполнена успешно");

            // Десериализация объектов из файла и вывод на экран
            if (File.Exists(filePath))
            {
                string jsonFromFile = File.ReadAllText(filePath);
                List<PC> deserializedPcs = JsonSerializer.Deserialize<List<PC>>(jsonFromFile);

                Console.WriteLine("Десериализация выполнена успешно. Результат:");
                foreach (PC pc in deserializedPcs)
                {
                    Console.WriteLine(pc);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}
