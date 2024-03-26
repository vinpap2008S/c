using System;
using System.Text;


class Город
{
    private int _количествоЖителей;

    public int КоличествоЖителей
    {
        get { return _количествоЖителей; }
        set { _количествоЖителей = value; }
    }

    public static Город operator +(Город город, int прирост)
    {
        город.КоличествоЖителей += прирост;
        return город;
    }

    public static Город operator -(Город город, int убыль)
    {
        город.КоличествоЖителей -= убыль;
        return город;
    }

    public static bool operator ==(Город город1, Город город2)
    {
        return город1.КоличествоЖителей == город2.КоличествоЖителей;
    }

    public static bool operator !=(Город город1, Город город2)
    {
        return !(город1 == город2);
    }

    public static bool operator <(Город город1, Город город2)
    {
        return город1.КоличествоЖителей < город2.КоличествоЖителей;
    }

    public static bool operator >(Город город1, Город город2)
    {
        return город1.КоличествоЖителей > город2.КоличествоЖителей;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Город other = (Город)obj;
        return this.КоличествоЖителей == other.КоличествоЖителей;
    }
}


class МузыкальныйИнструмент
{
    protected string название;

    public МузыкальныйИнструмент(string название)
    {
        this.название = название;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Звук музыкального инструмента");
    }

    public void Show()
    {
        Console.WriteLine($"Название: {название}");
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание музыкального инструмента");
    }

    public virtual void History()
    {
        Console.WriteLine("История создания музыкального инструмента");
    }
}

class Скрипка : МузыкальныйИнструмент
{
    public Скрипка(string название) : base(название) { }

    public override void Sound()
    {
        Console.WriteLine("Звук скрипки");
    }
}

class Тромбон : МузыкальныйИнструмент
{
    public Тромбон(string название) : base(название) { }

    public override void Sound()
    {
        Console.WriteLine("Звук тромбона");
    }
}

class Укулеле : МузыкальныйИнструмент
{
    public Укулеле(string название) : base(название) { }

    public override void Sound()
    {
        Console.WriteLine("Звук укулеле");
    }
}

class Виолончель : МузыкальныйИнструмент
{
    public Виолончель(string название) : base(название) { }

    public override void Sound()
    {
        Console.WriteLine("Звук виолончели");
    }
}


class Program
{
    static void Main()
    {

        Dictionary<char, string> morseCode = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."},
            {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
            {'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."}
        };

        // Функция для перевода текста в азбуку Морзе
        string ToMorseCode(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text.ToUpper())
            {
                if (morseCode.ContainsKey(c))
                {
                    result.Append(morseCode[c] + " ");
                }
                else if (c == ' ')
                {
                    result.Append("/ ");
                }
            }

            return result.ToString();
        }

        // Пример использования функции
        string userInput = "Hello World";
        string morseText = ToMorseCode(userInput);
        Console.WriteLine(morseText); // Выведет текст, переведенный в азбуку Морзе

    }
}
