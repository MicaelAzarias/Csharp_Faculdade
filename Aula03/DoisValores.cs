using System;
namespace MyApp // Namespace é um agrupamento de classes, métodos e outros namespaces
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
                Console.WriteLine("O Valor é ZERO.");
            }
            else if (r > 0)
            {
                Console.WriteLine("O valor é maior que zero.");
            }
            else if (r < 0)
            {
                Console.WriteLine("O valor é menor que zero");
            };
        }
    }
}