using System;

class Program
{
    static string InvertCase(string input)
    {
        int i = 0;
        char[] result = new char[input.Length];
        foreach (char c in input) {
            if (char.IsLower(c))
            {
                result[i] = char.ToUpper(c);
            }
            else
            {
                if (char.IsUpper(c))
                {
                    result[i] = char.ToLower(c);
                }
                else
                {
                    result[i] = c;
                }
            }
            i++;
        }
        return new string(result);
    }

    static int[] CountPosSumNeg(float[] result)
    {
        if (result.Length == 0)
            return new int[0];
        int count = 0;
        float sum = 0;
        foreach(float f in result)
        {
            if (f > 0)
                count++;
            if (f < 0)
                sum += f;
        }
        
        return new int[] { count, ((int)sum) };

    }

    static void CountPosSumNegWrite(int[] result)
    {
        if (result.Length == 0)
            Console.WriteLine("[]");
        else
            Console.WriteLine("[" + result[0] + ", " + result[1] + "]");


    }

    static void Main()
    {
        Console.WriteLine(InvertCase("Happy bursdfsdD"));
        Console.WriteLine(InvertCase("мама"));
        Console.WriteLine(InvertCase("ПРорывО"));

        CountPosSumNegWrite(CountPosSumNeg([]));
        CountPosSumNegWrite(CountPosSumNeg([1, 2, 5, -3, -5]));

    }
}
