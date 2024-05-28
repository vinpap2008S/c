using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ClassLib;

namespace SerializConsolApp
{
    class Program
    {
        static void Main()
        {
            List<PC> pcs = new List<PC>
            {
                new PC("Dell", "12345"),
                new PC("HP", "67890"),
                new PC("Lenovo", "54321"),
                new PC("Acer", "09876"),
                new PC("Asus", "13579")
            };

            string filePath = @"D:\listSerial.txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Старый файл удален");
            }

            string json = JsonSerializer.Serialize(pcs);
            File.WriteAllText(filePath, json);

            Console.WriteLine("Сериализация выполнена успешно");
        }
    }
}
