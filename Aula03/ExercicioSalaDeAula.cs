using System;

namespace MyApp // Namespace � um agrupamento de classes, m�todos e outros namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;

            Console.WriteLine("Qual � a sua idade aluno 1? ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual � a sua idade aluno 2? ");
            n2 = int.Parse(Console.ReadLine());
            r = n1 + n2;

            if (n1 > n2)
            {
                Console.WriteLine("a idade do aluno 1 � maior que a do aluno 2.");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("a idade do aluno 2 � maior que a do aluno 1.");
            }
            else
            {
                Console.WriteLine("as idades s�o iguais.");
            }
            ;
        }
    }
}