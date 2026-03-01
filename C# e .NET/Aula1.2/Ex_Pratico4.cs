namespace C__e_.NET.Aula1._2
{
    internal class Ex_Pratico4
    {
    /*
    Conversor de temperatura de celsius para fahrenheit
    Leia temperatura em celsius e imprima a temperatura em fahrenheit
    Compile e execute
    */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius");
            double celsius = double.Parse(Console.ReadLine());
            double faren = (celsius * 9 / 5 + 32);

            Console.WriteLine($"A temperatura Celsius é {celsius}° em Fahrenheit é: {faren} graus Fahrenheit");
        }
    }
}
