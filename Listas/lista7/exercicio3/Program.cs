using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("digite a idade do nadador");
        int IdadeNadador = Convert.ToInt32(Console.ReadLine());

        ClassificarNadador(IdadeNadador);

    }

    static int ClassificarNadador(int IdadeNadador)
    {
        const int IDADE_INFANTIL = 12;
        const int IDADE_JUVENIL_A = 14;
        const int IDADE_JUVENIL_B = 17;
        const int IDADE_ADULTO = 18;

        if (IdadeNadador < IDADE_INFANTIL)
        {
            System.Console.WriteLine("Infantil");
        }
        else if (IdadeNadador >= IDADE_INFANTIL && IdadeNadador <= IDADE_JUVENIL_A)
        {
            System.Console.WriteLine("Juvenil A");
        }
        else if (IdadeNadador > IDADE_JUVENIL_A && IdadeNadador <= IDADE_JUVENIL_B)
        {
            System.Console.WriteLine("Juvenil B");
        }
        else if (IdadeNadador >= IDADE_ADULTO)
        {
            System.Console.WriteLine("Adulto");
        }

        return IdadeNadador;
    }
}
