namespace C__e_.NET.Aula1._2
{
    internal class Ex_Pratico3
    {
        /*
        Calcule e imprima a média escolar de aluno com base em três notas (nome, nota1, nota2, nota3)
        Informe a situação atual do aluno (reprovado < 5; aprovado ≥ 7; recuperação 5 ≥ e < 7)
        Compile e execute
        */
        static void Main(string[] args)
        {
            Console.WriteLine("============== Calculadora de Média Escolar ==============");

            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media > 0 && media < 5)
            {
                Console.WriteLine($"Você foi Reprovado e sua media foi {media}!");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine($"Você está de Recuperação e sua media foi {media}!");
            }
            else if (media >= 7 && media <= 10)
            {
                Console.WriteLine($"Parabéns, você foi Aprovado e sua media foi {media}!");
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, insira notas entre 0 e 10.");


            }
        }
    }
}