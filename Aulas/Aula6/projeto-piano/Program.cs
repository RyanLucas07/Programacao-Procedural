class Program 
{
    static void Main(string[] args)
    {
        const int TAMANHO_OITAVA = 7;
        int contador = 1;
        while (contador <= TAMANHO_OITAVA)
        {
            Piano.ReproduzTecla(1, contador);
            contador++;
        }

    }
}