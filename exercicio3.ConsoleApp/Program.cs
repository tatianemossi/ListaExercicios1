using System;

namespace exercicio3.ConsoleApp
{
    internal class Program
    {
        /* Exercício 3:
        Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 
        dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();

            int diasDeVida = idade * 365;

            Console.WriteLine($"{nome} você já viveu {diasDeVida} dias de vida");

            Console.ReadLine();
        }
    }
}
