using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть символ: ");
        char symbol = char.ToUpper(Console.ReadLine()[0]);

        if ("AEIOU".Contains(symbol))
        {
            Console.WriteLine("Це голосна.");
        }
        else
        {
            Console.WriteLine("Це приголосна.");
        }
    }
}
