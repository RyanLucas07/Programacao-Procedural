using System;

class Program
{
    static void Main(string[] args)
    {
        const int MENOR_TAMANHO_ALTURA = 1;
        const int MAIOR_TAMANHO_ALTURA = 9;

        for (int contador = 1; contador == contador; contador++)
        {
            System.Console.WriteLine("Digite a altura deseja: ");
            int tamanhoAltura = int.Parse(Console.ReadLine());

            if(tamanhoAltura >= MENOR_TAMANHO_ALTURA && tamanhoAltura <= MAIOR_TAMANHO_ALTURA)
            {
                for(int linha = 1; linha <=tamanhoAltura; linha++)
                {
            
                    for (int coluna = 1; coluna <= tamanhoAltura; coluna++)
                    {            

                        if(coluna <= linha)
                        {
                            Console.Write(coluna);
                        }

                        
                                    
                    }
                    System.Console.WriteLine();
                }
            break;   
            }
            else 
            {
                System.Console.WriteLine("Alturta invalida, digite uma altura entre um e nove!");
            }
        }
    }
}