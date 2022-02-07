using System;

namespace exercicio4.ConsoleApp
{
    internal class Program
    {
        /* Exercício 4:
        Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo 
        para ler uma temperatura Celsius e imprimi-Ia em Fahrenheit.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em Graus Celsius?");
            var celsius = Convert.ToDouble(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"A temperatura é de {fahrenheit} graus Fahrenheit");

            Console.ReadLine();
        }
    }
}
