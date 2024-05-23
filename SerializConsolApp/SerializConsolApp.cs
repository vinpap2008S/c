using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLib;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pcList = new List<PC>();

            // Создание объектов класса PC и добавление их в коллекцию
            PC pc1 = new PC("Brand 1", 123);
            PC pc2 = new PC("Brand 2", 456);
            PC pc3 = new PC("Brand 3", 789);
            PC pc4 = new PC("Brand 4", 987);
            PC pc5 = new PC("Brand 5", 654);

            pcList.Add(pc1);
            pcList.Add(pc2);
            pcList.Add(pc3);
            pcList.Add(pc4);
            pcList.Add(pc5);

            // Путь к файлу для сериализации
            string filePath = @"D:\listSerial.txt";

            // Проверка наличия файла и его удаление, если он уже существует
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Старый файл удален.");
            }

            // Создание потока для записи в файл
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                // Создание объекта BinaryFormatter для сериализации
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // Сериализация коллекции в файл
                binaryFormatter.Serialize(fileStream, pcList);
            }

            Console.WriteLine("Сериализация успешно выполнена.");
        }
    }
}
