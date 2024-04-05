using System;

class Program
{
    static void Main(string[] args)
    {
       const int TAMANHO_VETOR = 3;
       int[] vetor = new int[TAMANHO_VETOR];

       int maiorValor = ReceberMaiorNumero(vetor);
    }
    static int ReceberMaiorNumero(int[] numeros)
    {
        const int TAMANHO_VETOR = 3;
        int maiorValor = 0;
       
       for(int i = 0; i < TAMANHO_VETOR; i++)
       {
        System.Console.WriteLine("Digite um numero: ");
        int numeroDigitado = int.Parse(Console.ReadLine());

        if(numeroDigitado > maiorValor)
        {
            maiorValor = numeroDigitado;
        }

       }
        System.Console.WriteLine(maiorValor);
       
       return maiorValor;

    }
}