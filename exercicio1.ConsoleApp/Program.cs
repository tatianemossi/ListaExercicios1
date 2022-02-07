using System;

namespace exercicio1.ConsoleApp
{
    internal class Program
    {
            // Exercício 1: 
            // A imobiliária Imóbilis vende apenas terrenos retangulares.
            // Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
            static void Main(string[] args)
            {
                Console.WriteLine("Informe a largura do terreno:");
                var larguraTerreno = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o comprimento do terreno:");
                var comprimentoTerreno = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("A área total do terreno é de: ");
                var totalTerreno = larguraTerreno * comprimentoTerreno;
                Console.WriteLine(totalTerreno);

                Console.ReadLine();
            }
    }
}
