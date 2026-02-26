namespace C__e_.NET.Aula1._1
{
    internal class Ex_Pratico3
    {/*
        Implemente um aplicativo console que imprima no console seu nome, idade e hobby
        Crie variáveis para conter os seus dados
        Crie um breakpoint na linha de código idade
        Execute linha a linha o seu aplicativo
        Altere o valor atribuído da variável idade (qualquer outro valor) em tempo de execução
        Finalize a execução do aplicativo e verifique a saída no console 
     */
        static void Main(string[] args)
        {
            String nome = "João Pedro Barboza Rigoto Ferreira";
            int idade = 19;
            String hobby = "Jogar Videogames";

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Hobby: {hobby}");
        }
    }
}
