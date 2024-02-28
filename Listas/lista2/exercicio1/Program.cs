using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome de usuario: ");
        string nomeDeUsuario = Console.ReadLine();

        Console.WriteLine("digite sua senha: ");
        string senhaDoUsuario = Console.ReadLine();

        if(nomeDeUsuario == "admin" && senhaDoUsuario == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas...");
        }
    }
}