using System;

class Program
{
    static void Main(string[] args)
    {
        for(int crescente = 0, decrescente = 200; crescente <= 100; crescente += 2, decrescente -= 4)
        {
            System.Console.WriteLine($"{crescente} - {decrescente}");
        }
    }
}