using System;
using System;

namespace ГенераторТекста
{
    class Программа
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество гласных:");
            int количествоГласных = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество согласных:");
            int количествоСогласных = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальную длину слова:");
            int максДлинаСлова = Convert.ToInt32(Console.ReadLine());

            ГенераторТекста.СгенерироватьТекст(количествоГласных, количествоСогласных, максДлинаСлова);
        }
    }

    class ГенераторТекста
    {
        public static void СгенерироватьТекст(int количествоГласных, int количествоСогласных, int максДлинаСлова)
        {
            Random rand = new Random();
            string гласные = "aeiou";
            string согласные = "bcdfghjklmnpqrstvwxyz";
            string текст = "";

            for (int i = 0; i < количествоГласных + количествоСогласных; i++)
            {
                if (i % 2 == 0 && количествоГласных > 0)
                {
                    текст += гласные[rand.Next(гласные.Length)];
                    количествоГласных--;
                }
                else if (количествоСогласных > 0)
                {
                    текст += согласные[rand.Next(согласные.Length)];
                    количествоСогласных--;
                }

                if (текст.Length >= максДлинаСлова || (количествоГласных == 0 && количествоСогласных == 0))
                {
                    Console.Write(текст + " ");
                    текст = "";
                }
            }
        }
    }
}

namespace Игра
{
    class УгадайЧисло
    {
        public static void НачатьИгру(int минЗначение, int максЗначение)
        {
            Random rand = new Random();
            int загаданноеЧисло = rand.Next(минЗначение, максЗначение + 1);
            int предполагаемоеЧисло = 0;

            Console.WriteLine($"Загадано число от {минЗначение} до {максЗначение}. Попробуйте угадать!");

            do
            {
                предполагаемоеЧисло = Convert.ToInt32(Console.ReadLine());

                if (предполагаемоеЧисло < загаданноеЧисло)
                {
                    Console.WriteLine("Загаданное число больше. Попробуйте еще раз.");
                }
                else if (предполагаемоеЧисло > загаданноеЧисло)
                {
                    Console.WriteLine("Загаданное число меньше. Попробуйте еще раз.");
                }
            } while (предполагаемоеЧисло != загаданноеЧисло);

            Console.WriteLine("Поздравляем! Вы угадали число!");
        }
    }
}
