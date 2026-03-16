using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula2._2;

internal class Ex_Pratico1
{
    static void Main(string[] args)
    {
        try
        {
            double precoSedan = 80000.00;
            double precoSUV = 120000.00;
            double total = 0;

            Console.WriteLine("--- CONCESSIONÁRIA AUTO-TECH ---");
            Console.WriteLine("1 - Sedan Luxo: R$ 80.000,00");
            Console.WriteLine("2 - SUV Premium: R$ 120.000,00");
            Console.Write("Escolha o modelo (1 ou 2): ");

            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= 0)
            {
                Console.WriteLine("Erro: A quantidade deve ser maior que zero.");
                return;
            }

            if (opcao == 1) total = precoSedan * quantidade;
            else if (opcao == 2) total = precoSUV * quantidade;
            else
            {
                Console.WriteLine("Opção inválida.");
                return;
            }

            if (total > 200) // Aplica desconto conforme regra (neste caso, carros sempre passam de 200)
            {
                total *= 0.90;
                Console.WriteLine("Desconto de 10% aplicado!");
            }

            Console.WriteLine($"Total do pedido: R$ {total:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, insira apenas números válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}
