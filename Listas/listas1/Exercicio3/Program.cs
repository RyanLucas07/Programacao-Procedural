using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Digite quantos centavos deseja converter a Reais!: ");
        int dinheiro = int.Parse(Console.ReadLine());
        
        int reais = dinheiro / 100;
        int centavos = dinheiro % 100;

        Console.WriteLine("O total em dinheiro eh: " + reais + " real(is) e " + centavos + " centavo(s)");
    }
}