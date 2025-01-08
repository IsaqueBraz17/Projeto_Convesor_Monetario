using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Monetário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### CONVERSÃO MONETÁRIA ###");
            Console.WriteLine();

            Console.WriteLine("Opções de conversão para Real (R$):");
            Console.WriteLine("[1] USA - Dólar - R$6,12");
            Console.WriteLine("[2] EUR - Euro - R$6,30");
            Console.WriteLine();

            int conversao;
            while (true)
            {
                Console.Write("Escolha uma opção acima: ");
                if (int.TryParse(Console.ReadLine(), out conversao) && (conversao == 1 || conversao == 2))
                {
                    break; // Sai do loop se a entrada for válida
                }
                Console.WriteLine("Opção inválida! Por favor, insira 1 ou 2.");
            }

            Console.WriteLine();

            Console.Write("\nDigite o valor que vai ser convertido: ");
            if (!double.TryParse(Console.ReadLine(), out double valor) || valor <= 0)
            {
                Console.WriteLine("Valor inválido! Por favor, insira um número maior que zero.");
                return;
            }

            Console.WriteLine();

            double taxaConversao = conversao == 1 ? 6.12 : 6.30;
            string moeda = conversao == 1 ? "USD" : "EUR";
            double resultado = valor * taxaConversao;

            Console.WriteLine($"Conversão de {moeda}: {valor:F2} / Resultado: R${resultado:F2}");
        }
    }
}

