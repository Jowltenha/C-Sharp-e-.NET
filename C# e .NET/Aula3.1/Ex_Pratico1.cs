using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula3._1;

internal class Ex_Pratico1
{
    static void Main()
    {
        List<string> frutas = new List<string> { "Banana", "Abacaxi", "Bacuri", "Morango", "Bergamota" };

        var filtro = frutas.Where(f => f.StartsWith("b", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Frutas que começam com 'B':");
        foreach (var fruta in filtro)
        {
            Console.WriteLine($"- {fruta}");
        }
    }
}