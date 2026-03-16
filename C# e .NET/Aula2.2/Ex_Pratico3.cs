using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula2._2;

internal class Ex_Pratico3
{
    static void Main()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Nota 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        double n3 = double.Parse(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;
        Console.WriteLine($"\nAluno: {nome} | Média: {media:F1}");

        if (media >= 7) Console.WriteLine("Situação: Aprovado");
        else if (media >= 5) Console.WriteLine("Situação: Recuperação");
        else Console.WriteLine("Situação: Reprovado");
    }
}
