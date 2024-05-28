using System;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        public string Brand { get; set; }
        public string SerialNumber { get; set; }

        public PC()
        {
            // Конструктор по умолчанию
        }

        public PC(string brand, string serialNumber)
        {
            Brand = brand;
            SerialNumber = serialNumber;
        }

        public void TurnOn()
        {
            Console.WriteLine("Компьютер включен");
        }

        public void TurnOff()
        {
            Console.WriteLine("Компьютер выключен");
        }

        public override string ToString()
        {
            return $"Марка: {Brand}, Серийный номер: {SerialNumber}";
        }
    }
}
