using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using ClassLib;

class Program
{
    static void Main(string[] args)
    {
        // Путь к файлу с сериализованной коллекцией
        string filePath = "SerializedCollection.json";

        // Прочитать сериализованную коллекцию из файла
        string jsonString = File.ReadAllText(filePath);

        // Десериализовать коллекцию в объект Collection<T>
        Collection<char> deserializedCollection = JsonSerializer.Deserialize<Collection<char>>(jsonString);

        // Вывести имена людей в коллекции на экран
        foreach (char person in deserializedCollection)
        {
            Console.WriteLine(person);
        }
    }
}
