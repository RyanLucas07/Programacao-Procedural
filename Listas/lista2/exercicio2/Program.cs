using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua terceira nota:");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua Quarta nota:");
        double nota4 = double.Parse(Console.ReadLine());

        double notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

        if(notaFinal >= 5.0)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if(notaFinal < 5.0 && notaFinal >= 3.0)
        {
            Console.WriteLine("Aluno em recuperação");
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
}