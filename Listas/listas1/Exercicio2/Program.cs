using System;

class Program
{
   static void Main(string[] args)
   {
    Console.WriteLine("Qual a base do triangulo?:");
      double base1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual a altura do triangulo?:");
      double altura = double.Parse(Console.ReadLine());

      double area = (base1 * altura) / 2;
      bool resultado = area > 20;
    
    Console.WriteLine("A area do triangulo eh maior que 20?: " + resultado );

    }

}

