using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual sua primeira nota?:");
           double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual sua segunda nota?:");
           double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual sua terceira nota?:");
           double nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual sua quarta nota?:");
           double nota4 = double.Parse(Console.ReadLine());

        double resultado = (nota1 + nota2 + nota3 + nota4) / 4.0;

        Console.WriteLine("A media do aluno eh: " + resultado);
        
    }
}