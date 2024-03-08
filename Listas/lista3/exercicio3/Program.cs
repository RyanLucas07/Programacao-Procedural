using System;

class Program
{
    static void Main(string[] args)
    {
        const string NOME_DE_USUARIO_CORRETO = "admin";
        const string SENHA_CORRETA = "123senha";
        int contadorTentativas = 1;
        const int NUMERO_MAXIMO_DE_TENTATIVAS = 3;

        do
        {
            System.Console.WriteLine("\ndigite o seu nome de usuario: ");
            string nomeDeUsuario = Console.ReadLine();
            System.Console.WriteLine("digite a sua senha: ");
            string senhaDoUsuario = Console.ReadLine();
            
            if (nomeDeUsuario == NOME_DE_USUARIO_CORRETO && senhaDoUsuario ==SENHA_CORRETA)
            {
                System.Console.WriteLine("Login realizado com sucessso");
                break;
            }
            contadorTentativas++;

        }
        while(contadorTentativas <= NUMERO_MAXIMO_DE_TENTATIVAS);

        if (contadorTentativas > NUMERO_MAXIMO_DE_TENTATIVAS)
        {
            System.Console.WriteLine("Sua conta foi bloqueada");
        }       
    }
}