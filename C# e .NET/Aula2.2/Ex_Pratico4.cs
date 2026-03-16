using System;
using System.Collections.Generic;
using System.Text;

namespace C__e_.NET.Aula2._2;

internal class Ex_Pratico4
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 1.8) + 32;

        Console.WriteLine($"{celsius}°C equivalem a {fahrenheit:F1}°F");
    }
}
