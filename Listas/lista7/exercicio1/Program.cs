using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        
        bool retorno = EhPar(valor);
        System.Console.WriteLine(retorno);
    }

    static bool EhPar(int par)
    {
        return par % 2 == 0;
    }
}