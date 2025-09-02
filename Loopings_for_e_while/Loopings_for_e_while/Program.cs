using System;

class Program
{
    static void Main(string[] args)
    {
        // Altura da pirâmide
        int altura = 6;

        // Caractere que será usado para formar a pirâmide
        char simbolo = '*';

        // Linha atual começa em 1
        int linha = 1;

        Console.WriteLine("Pirâmide usando WHILE:\n");

        // Loop while para gerar a pirâmide
        while (linha <= altura)
        {
            // Imprime os espaços em branco antes dos caracteres
            int espacos = altura - linha;
            int contadorEspacos = 0;

            while (contadorEspacos < espacos)
            {
                Console.Write(" ");
                contadorEspacos++;
            }

            // Imprime os caracteres da linha
            int contadorCaracteres = 0;
            while (contadorCaracteres < (2 * linha - 1))
            {
                Console.Write(simbolo);
                contadorCaracteres++;
            }

            // Quebra de linha
            Console.WriteLine();

            // Avança para a próxima linha
            linha++;
        }
    }
}
