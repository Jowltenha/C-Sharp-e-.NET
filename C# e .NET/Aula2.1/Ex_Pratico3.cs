namespace C__e_.NET.Aula2._1
{
    internal class Ex_Pratico3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--- Sistema de Notas Escolares ---");

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a Nota 1: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a Nota 2: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a Nota 3: ");
                double n3 = double.Parse(Console.ReadLine());

                double media = (n1 + n2 + n3) / 3;

                Console.WriteLine($"\nAluno: {nome}");
                Console.WriteLine($"Média Final: {media:F1}");

                // Verificação da situação
                if (media >= 7)
                {
                    Console.WriteLine("Situação: APROVADO! 🎉");
                }
                else if (media >= 5 && media < 7)
                {
                    Console.WriteLine("Situação: RECUPERAÇÃO. 📝");
                }
                else
                {
                    Console.WriteLine("Situação: REPROVADO. ❌");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, insira notas válidas usando números.");
            }
        
        }
    }
}
