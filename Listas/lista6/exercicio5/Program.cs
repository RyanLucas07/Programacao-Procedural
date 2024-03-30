using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        const int TAMANHO_MINIMO = 10;
        const int TAMANHO_MAXIMO = 50;

        int [] numerosDigitados = new int[TAMANHO_VETOR];

        int contador = 0;
        while(contador < TAMANHO_VETOR)
        {
            System.Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= TAMANHO_MINIMO && numero <= TAMANHO_MAXIMO)
            {
                numerosDigitados[contador] = numero;
                contador++;
            }

        }
        
        for(contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            System.Console.WriteLine(numerosDigitados[contador]);
        }
    }
}