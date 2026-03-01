namespace C__e_.NET.Aula1._2
{
    internal class Ex_Pratico1
    {
    /*
    Implemente um programa de caixa registradora para uma loja (tema do aluno)
    O programa deve calcular o total de um pedido apenas uma vez por execução do programa
    Imprima duas opções de de produto da loja (ex: 1 - beef burguer e 2 - fish burguer)
    Considere que o produto 1 e 2 tenham valor fixo de R$ 50,00 e R$ 60,00 respectivamente
    Leia a opção de produto desejado pelo usuário
    Leia a quantidade desejada, calcule e imprima o total do pedido    
    --> LOJA DE CARROS
    */
        static void Main(string[] args)
        {
            bool caixaAberto = true;

            Console.WriteLine("============== Bem-vindo à minha loja p/de carros! Jocarro ==============");

            while (caixaAberto)
            {
                Console.WriteLine("1. Comprar um carro");
                Console.WriteLine("2. Apetrechos para carro");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Você escolheu comprar um carro!");

                        break;
                    case "2":
                        Console.WriteLine("Você escolheu comprar apetrechos para carro");
                        Console.WriteLine("Selecione o produto:");
                        Console.WriteLine("1 - Pneu Aro 15 (R$ 450,00)");
                        Console.WriteLine("2 - Kit Troca de Óleo (R$ 180,00)");
                        Console.WriteLine("3 - Bateria 60Ah (R$ 350,00)");
                        Console.WriteLine("4 - Jogo de Tapetes (R$ 100,00)");

                        Console.WriteLine("Escolha sua opção");
                        string produtoEscolhido = Console.ReadLine();
                        switch (produtoEscolhido)
                        {
                            case "1":
                                Console.WriteLine("Você escolheu o Pneu Aro 15 por R$ 450,00");
                                break;
                            case "2":
                                Console.WriteLine("Você escolheu o Kit Troca de Óleo por R$ 180,00");
                                break;
                            case "3":
                                Console.WriteLine("Você escolheu a Bateria 60Ah por R$ 350,00");
                                break;
                            case "4":
                                Console.WriteLine("Você escolheu o Jogo de Tapetes por R$ 100,00");
                                break;
                            default:
                                Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                                break;
                        }

                        break;
                    case "3":
                        Console.WriteLine("Saindo da loja. Obrigado por visitar!");
                        caixaAberto = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        break;
                }

            }
        }
    }
}
