using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula3._1;

internal class Ex_pratico2
{
    static void Main()
    {
        var estoque = new[]
        {
            new { Nome = "Laranja", EhCitrica = true },
            new { Nome = "Maçã", EhCitrica = false },
            new { Nome = "Limão", EhCitrica = true },
            new { Nome = "Pera", EhCitrica = false },
            new { Nome = "Tangerina", EhCitrica = true }
        };

        var citricas = estoque.Where(f => f.EhCitrica);

        Console.WriteLine("Lista de Frutas Cítricas:");
        foreach (var fruta in citricas)
        {
            Console.WriteLine($"- {fruta.Nome}");
        }
    }
}
