using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 10; contador >= 0; contador--)
        {
            for (int contador2 = 0; contador2 <= 10; contador2++)
            {
                System.Console.WriteLine($"{contador} X {contador2} = {contador * contador2}");
            }
            System.Console.WriteLine("\n");
        }
    }
}