using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome da criança:");
        string nomeDaCrianca = Console.ReadLine();

        if(nomeDaCrianca == "Joselito")
        {
            Console.WriteLine("Rotina de Joselito:");
            Console.WriteLine("1. Escola das 07h as 12:30h");
            Console.WriteLine("2. Almoço das 13h as 14");
            Console.WriteLine("3. Natação das 14h as 16h");
            Console.WriteLine("4. Reforço escolar das 16h as 19h");
        }
        else if(nomeDaCrianca == "Filomena")
        {
            Console.WriteLine("Rotina de Filomena:");
            Console.WriteLine("1. Escola das 07h as 12h");
            Console.WriteLine("2. Almoço das 12h as 13h");
            Console.WriteLine("3. Futebol das 14h as 16h");
            Console.WriteLine("4. Dever de casa das 16h as 18h");
        }
        else
        {
            Console.WriteLine("Criança inexistente...!");
        }
    }

}