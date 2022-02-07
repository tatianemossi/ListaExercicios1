using System;

namespace exercicio2.ConsoleApp
{
    internal class Program
    {
        /*Exercício 2:
        A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas acada dia. 
       Cada pãozinho custa R$ 0,12 e a broa custa R$1,50. Ao final do dia, o dono quer saber quanto arrecadou 
       com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total 
       arrecadado). Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um 
       algoritmo para ler as quantidades de pães e de broas, edepois calcular os dados solicitados.
       */
            static void Main(string[] args)
            {
                Console.WriteLine("Digite a quantidade de pães vendidos:");
                int paes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de broas vendidas:");
                int broas = Convert.ToInt32(Console.ReadLine());

                var totalPaes = paes * 0.12;
                var totalBroas = broas * 1.50;
                var valorTotalGeral = totalPaes + totalBroas;
                Console.WriteLine($"O total vendido de pães e broas é de: {valorTotalGeral} reais");

                var valorPoupanca = valorTotalGeral * 0.10;
                Console.WriteLine("Valor a ser guardado na Poupança: " + valorPoupanca.ToString("F"));

                Console.WriteLine();

                Console.ReadLine();
            }
    }
}
