using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a tabuada desejada: ");
        int valorRecebido = int.Parse(Console.ReadLine());

        for(int contador = 1; contador <= 10; contador++)
        {
         System.Console.WriteLine(valorRecebido * contador);
        }
    }
}