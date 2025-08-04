// See https://aka.ms/new-console-template for more information
using System; // bibilioteca do sistema

namespace MyApp // Namespace é um agrupamento de classes, métodos e outros namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Define a cor de fundo do console
            Console.ForegroundColor = ConsoleColor.White; // Define a cor do texto do console
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("teste teste teste");
            Console.Write("teste teste teste");
            Console.CursorSize = 50; 
        }
    }
}