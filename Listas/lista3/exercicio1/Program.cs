using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_DE_HABITANTES = 3;
        int somatorioDeFilhos = 0;
        double somatorioSalarios = 0;
        double maiorSalario = 0;

        for (int contador = 1; contador <= NUMERO_DE_HABITANTES; contador++)
        {
            System.Console.WriteLine("Digite o Salario do " + contador + "º habitante: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Quantidade de filhos do " + contador + "º habitante: ");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioSalarios = somatorioSalarios + salarioAtual;
            somatorioDeFilhos = somatorioDeFilhos + numeroDeFilhos;
            if(salarioAtual > maiorSalario)
            {
               maiorSalario = salarioAtual; 
            }
            

        }
        somatorioDeFilhos = somatorioDeFilhos / NUMERO_DE_HABITANTES;
        somatorioSalarios = somatorioSalarios / NUMERO_DE_HABITANTES;

        System.Console.WriteLine("A media salarial é = R$" + Math.Round(somatorioSalarios, 2));
        System.Console.WriteLine(" A media de filhos por habitantes é = " + somatorioDeFilhos);
        System.Console.WriteLine("O maior salario é = R$" + maiorSalario);
    }
}