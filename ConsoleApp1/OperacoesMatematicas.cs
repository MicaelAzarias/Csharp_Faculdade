using System;

public class Class1
{
	public Class1()
	{
		string nome;
		float valor1;
		float valor2;

        Console.WriteLine("Ola qual é o seu nome: ")
		nome = Console.ReadLine();
        Console.WriteLine($"Ola {nome}");

		Console.WriteLine($"Por favor {nome}, insira o primeiro valor: ");
		valor1 = float.Parse(Console.ReadLine());
		Console.WriteLine($"Por favor {nome}, insira o segundo valor: ");
		valor2 = float.Parse(Console.ReadLine());

        float resultadoSoma = valor1 + valor2;
        float resultadoSubtracao = valor1 - valor2;
        float resultadoMultiplicacao = valor1 * valor2;
        float resultadoDivisao = valor1 / valor2;

        Console.WriteLine($"Os resultados, da soma é {resultadoSoma} \n, da subtração {resultadoSubtracao}\n , da multiplicação {resultadoMultiplicacao} \n e divisão {resultadoDivisao} ");
	
		




    }
}
