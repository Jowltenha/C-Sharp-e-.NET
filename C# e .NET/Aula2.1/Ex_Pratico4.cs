namespace C__e_.NET.Aula2._1
{
    internal class Ex_Pratico4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Conversor Celsius para Fahrenheit ---");

            try
            {
                Console.Write("Digite a temperatura em graus Celsius (°C): ");
                double celsius = double.Parse(Console.ReadLine());

                // Fórmula: F = (C * 9/5) + 32  ou  F = (C * 1.8) + 32
                double fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
                Console.WriteLine("------------------------------------------");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite um valor numérico válido para a temperatura.");
            }
        }
    }
}
