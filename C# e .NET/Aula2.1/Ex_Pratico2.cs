namespace C__e_.NET.Aula2._1
{
    internal class Ex_Pratico2
    {
    /*
    Calcule o IMC de uma pessoa (peso / altura)
    Imprima no console as classificações de acordo com a OMS (abaixo do peso, normal, sobrepeso, obesidade)
    Compile e execute 
    */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double calculoIMC = peso / (altura * altura);

            if (calculoIMC < 18.5)
            {
                Console.WriteLine($"Você está abaixo do peso {calculoIMC}");
            } else if (calculoIMC >= 18.5 && calculoIMC <= 24.9)
            {
                Console.WriteLine($"Você está no peso ideal! {calculoIMC}");
            } else if (calculoIMC >= 25.0 && calculoIMC <= 29.9)
            {
                Console.WriteLine($"Você está com sobrepeso {calculoIMC}");
            } else if (calculoIMC >= 30.0 && calculoIMC <= 34.9)
            {
                Console.WriteLine($"Você está com Obesidade Grau I {calculoIMC}");
            } else if (calculoIMC >= 35.0 && calculoIMC <= 39.9)
            {
                Console.WriteLine($"Você está com Obesidade Grau II {calculoIMC}");
            } else if (calculoIMC > 40.0)
            {
                Console.WriteLine($"Você está com Obesidade Grau III {calculoIMC}");
            }
        }
    }
}
