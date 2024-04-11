using System;

struct Pizza
{
    public int id;
    public double valor;
    public string sabor;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza pizzaDigitada;
        System.Console.WriteLine("Digite o id da pizza: ");
        pizzaDigitada.id = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o sabor da pizza: ");
        pizzaDigitada.sabor = Console.ReadLine();

        System.Console.WriteLine("Digite o valor da pizza: ");
        pizzaDigitada.valor = double.Parse(Console.ReadLine());

        System.Console.WriteLine(pizzaDigitada.id);
        System.Console.WriteLine(pizzaDigitada.sabor);
        System.Console.WriteLine(pizzaDigitada.valor);
    }
}