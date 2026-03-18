using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula3._1;

internal class Ex_Pratico3
{
    static void Main()
    {
        int[] numeros = { 1, 12, 23, 34, 45, 56, 67, 78, 89, 90 };

        var impares = numeros.Where(n => n % 2 != 0);

        Console.WriteLine("Números Ímpares da coleção:");
        foreach (var n in impares)
        {
            Console.Write($"{n} ");
        }
    }
}
