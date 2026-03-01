namespace C__e_.NET.Aula1._2
{
/*
Calcule o IMC de uma pessoa (peso / (altura * altura))
Imprima no console as classificações de acordo com a OMS (abaixo do peso, normal, sobrepeso, obesidade)
Compile e execute
*/
    internal class Ex_Pratico2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Calculadora de IMC ==============");

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Seu peso é {peso} e sua altura é {altura}.");
            Console.WriteLine($"Seu IMC é {imc}.");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Classificação: Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
        }
    }
}
