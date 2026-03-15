namespace C__e_.NET.Aula2._1
{
    internal class Ex_Pratico1
    {
    /*
    Implemente um programa de caixa registradora para uma loja (tema do aluno)
    Imprima uma lista de menu com opções de produto da loja
    Leia a opção de produto desejado pelo usuário
    Leia a quantidade desejada, calcule e imprima o total do pedido
    Realize um desconto de 50% no total calculado apenas para o quinto pedido do dia
    Ofereça uma opção para reiniciar a caixa registradora e outra opção para sair
    Compile e execute
    ---> Loja de Carros
    */
        static void Main(string[] args)
        {

            bool caixaAberto = true;

            Console.WriteLine("============== Bem-vindo à minha loja p/de carros! Jocarro ==============");

            while (caixaAberto)
            {
                try
                {
                    Console.WriteLine("\n============== Jocarro - Peças e Acessórios ==============");
                    Console.WriteLine("1. Pneu Aro 15 (R$ 450,00)");
                    Console.WriteLine("2. Kit Troca de Óleo (R$ 180,00)");
                    Console.WriteLine("3. Sair");
                    Console.Write("Escolha uma opção: ");

                    string opcao = Console.ReadLine();

                    if (opcao == "3")
                    {
                        Console.WriteLine("Saindo... Obrigado por visitar a Jocarro!");
                        break;
                    }

                    double precoUnitario = 0;
                    string nomeProduto = "";

                    // Atribuição de valores baseada na escolha
                    if (opcao == "1")
                    {
                        precoUnitario = 450.00;
                        nomeProduto = "Pneu Aro 15";
                    }
                    else if (opcao == "2")
                    {
                        precoUnitario = 180.00;
                        nomeProduto = "Kit Troca de Óleo";
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        continue;
                    }

                    // Leitura da quantidade com validação
                    Console.Write($"Quantas unidades de '{nomeProduto}' você deseja? ");
                    int quantidade = int.Parse(Console.ReadLine());

                    if (quantidade <= 0)
                    {
                        Console.WriteLine("Erro: A quantidade deve ser maior que zero.");
                        continue;
                    }

                    // Cálculo do Total
                    double total = precoUnitario * quantidade;

                    // Aplicação do desconto de 10% para pedidos acima de R$ 200,00
                    if (total > 200)
                    {
                        double desconto = total * 0.10;
                        total -= desconto;
                        Console.WriteLine("--- Desconto de 10% aplicado (Pedido acima de R$ 200)! ---");
                    }

                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Produto: {nomeProduto}");
                    Console.WriteLine($"Quantidade: {quantidade}");
                    Console.WriteLine($"Total a pagar: R$ {total:F2}");
                    Console.WriteLine("------------------------------------------");

                    // Opção para reiniciar ou sair
                    Console.WriteLine("\nDeseja realizar uma nova operação? (S/N)");
                    if (Console.ReadLine().ToUpper() != "S")
                    {
                        caixaAberto = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro de entrada: Por favor, digite apenas números para a quantidade.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }
            }
        }
    }
}