using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Qual o tamanho da base: ");
        int baseRetangulo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Qual o tamanho da altura:");
        int alturaRetangulo = int.Parse(Console.ReadLine());

        for(int coluna = 1; coluna <= baseRetangulo; coluna++)
        {
            for(int linha = 1; linha <= alturaRetangulo; linha++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}