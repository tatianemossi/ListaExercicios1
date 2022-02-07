using System;

namespace exercicio5.ConsoleApp
{
    internal class Program
    {
        /* Exercício 5:
         Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 
        8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salário");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());

            double aumentoSalario = salarioInicial * 0.15;

            double salarioAumento15 = salarioInicial + aumentoSalario;
            Console.WriteLine($"O valor do seu salário com aumento de 15% é de {salarioAumento15} reais");

            double salarioAtual = salarioAumento15 - (0.08 * salarioAumento15);
            Console.WriteLine($"O valor atual do seu salário com o aumento de 15% e o desconto de 8% é de: {salarioAtual} reais");

            Console.ReadLine();
        }
    }
}
