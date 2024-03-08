using System;

class Program
{
    static void Main(string[] args)
    {
        const double FRETE_GRATIS = 150;
        double valorTotalItens = 0;
        double precoDosItens = 0;

        int contador = 1;
        
        System.Console.WriteLine("Qual a quantidade de itens comprados na loja?: ");
        int quantidadeItensComprados = int.Parse(Console.ReadLine());

        while (contador <= quantidadeItensComprados)
        {
            System.Console.WriteLine("Qual o preço do " + contador + "º item?:");
            precoDosItens = double.Parse(Console.ReadLine());

            valorTotalItens = valorTotalItens + precoDosItens;
            contador++;
        }
        if(valorTotalItens >= FRETE_GRATIS)
        {
            System.Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra no valor de: R$" + Math.Round(valorTotalItens, 2));
        }

        else
        {
            System.Console.WriteLine("Sua compra nao possui frete gratis!");
        }
    }
}