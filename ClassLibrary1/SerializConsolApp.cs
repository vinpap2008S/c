using ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializConsolApp
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            // Создать коллекцию объектов класса PC
            List<PC> pcs = new List<PC>();
            pcs.Add(new PC { id = 1, name = "PC1", price = 1000 });
            pcs.Add(new PC { id = 2, name = "PC2", price = 1200 });
            pcs.Add(new PC { id = 3, name = "PC3", price = 1400 });
            pcs.Add(new PC { id = 4, name = "PC4", price = 1600 });
            pcs.Add(new PC { id = 5, name = "PC5", price = 1800 });

            // Указать путь к файлу для сериализации
            string filePath = @"D:\listSerial.txt";

            // Проверить наличие существующего файла и перезаписать его новым файлом при необходимости
            if (File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} уже существует. Он будет перезаписан.");
            }

            // Открыть поток для сериализации
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                // Создать сериализатор
                BinaryFormatter formatter = new BinaryFormatter();

                // Сериализовать коллекцию в файл
                formatter.Serialize(fileStream, pcs);
            }

            Console.WriteLine("Коллекция успешно сериализована в файл {filePath}.");
        }
    }
}
