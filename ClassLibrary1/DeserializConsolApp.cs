using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ClassLib;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main()
        {
            string filePath = @"D:\listSerial.txt";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<PC> pcs = JsonSerializer.Deserialize<List<PC>>(json);

                foreach (PC pc in pcs)
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
