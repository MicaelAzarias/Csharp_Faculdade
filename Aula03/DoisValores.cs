using System;
namespace MyApp // Namespace � um agrupamento de classes, m�todos e outros namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;
            Console.WriteLine("insira o valor n1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor n2");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            if (r == 0)
            {
                Console.WriteLine("O Valor � ZERO.");
            }
            else if (r > 0)
            {
                Console.WriteLine("O valor � maior que zero.");
            }
            else if (r < 0)
            {
                Console.WriteLine("O valor � menor que zero");
            };
        }
    }
}