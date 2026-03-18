using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula3._1;

internal class Ex_Pratico4
{
    static void Main()
    {
        double totalGeral = 0;
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- TECH STORE - CAIXA ---");
            Console.WriteLine("1. Processador Ryzen 7 - R$ 1800,00");
            Console.WriteLine("2. Placa de Vídeo RTX 4060 - R$ 2200,00");
            Console.WriteLine("3. CALCULAR TOTAL");
            Console.WriteLine("4. SAIR");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ProcessarPedido("Processador Ryzen 7", 1800.00, ref totalGeral);
                    break;
                case "2":
                    ProcessarPedido("Placa de Vídeo RTX 4060", 2200.00, ref totalGeral);
                    break;
                case "3":
                    Console.WriteLine($"\n>>> TOTAL ACUMULADO: R$ {totalGeral:F2}");
                    break;
                case "4":
                    Console.WriteLine("Encerrando sistema...");
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void ProcessarPedido(string nome, double preco, ref double total)
    {
        Console.Write($"Quantidade de {nome}: ");
        if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
        {
            total += preco * qtd;
            Console.WriteLine($"{qtd} unidade(s) adicionada(s).");
        }
        else
        {
            Console.WriteLine("Quantidade inválida.");
        }
    }
}
