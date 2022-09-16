using System;
using System.Diagnostics.Metrics;

public class Exercise1
{
    public static void Main()
    {
        char letter, letter1, letter2;
        Console.Write("Input leter: ");
        letter = Convert.ToChar(Console.ReadLine());
        Console.Write("Input leter: ");
        letter1 = Convert.ToChar(Console.ReadLine());
        Console.Write("Input leter: ");
        letter2 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);

    }
}
