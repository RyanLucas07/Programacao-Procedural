using System;

struct Produto
{
    public int id;
    public double valor;
    public string nome;
    public bool disponivelEmEstoque;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;

        Produto[] produtos = new Produto[TAMANHO_VETOR];

        for(int i = 0; i < produtos.Length; i++)
        {
            System.Console.WriteLine("Digite o id do produto");
            produtos[i].id = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do produto");
            produtos[i].nome = Console.ReadLine();

            System.Console.WriteLine("Digite o valor do produto");
            produtos[i].valor = double.Parse(Console.ReadLine());

            System.Console.WriteLine("O produto esta em estoque? ");
            produtos[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }
        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].valor);
            }
        }
    }
}