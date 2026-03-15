# Aula 6.1("11") - Assuntos cobertos: Programação orientada a objetos (interface)

# Interfaces e o Princípio de Segregação de Interface (ISP)

### O que é uma Interface?
Em C#, uma Interface é um contrato que define um conjunto de funcionalidades que uma classe ou struct deve implementar. Ela não possui estado (campos) e, tradicionalmente, define apenas "o que" deve ser feito, não "como".

- Palavra-chave: interface.
- Convenção de Nomenclatura: Inicia-se com a letra "I" (ex: IGravavel, IProcessadorPedido).
- Relacionamento: Define um comportamento do tipo "faz algo" (can-do), ao contrário da herança de classe que define "é um" (is-a).

### Interface Segregation Principle (ISP)
O quarto princípio do SOLID afirma que "clientes não devem ser forçados a depender de interfaces que não utilizam".

Em termos práticos: é melhor ter várias interfaces específicas do que uma única interface "generalista" e pesada. Isso evita que uma classe seja obrigada a implementar métodos que ela não precisa (muitas vezes resultando no erro NotImplementedException).

### Exemplo de Uso: Relacionamento "Faz Algo"
Imagine um sistema de restaurante. Nem todo funcionário pode fechar um pedido, mas o garçom sim.
    
    // Interface específica para quem tem permissão de fechar pedidos
    public interface IFechadorPedido
    {
        void FecharPedido(int pedidoId);
    }
    
    public class Garcom : Funcionario, IFechadorPedido
    {
        public void FecharPedido(int pedidoId)
        {
            Console.WriteLine($"Pedido {pedidoId} fechado com sucesso.");
        }
    }

Neste exemplo, o Garcom "faz" a ação de fechar pedido porque implementa o contrato específico para isso. Se tivéssemos uma interface única IFuncionario com o método FecharPedido, um Cozinheiro seria obrigado a implementá-lo mesmo sem ter essa função.

# 🔍 Filtragem e Reflexão com Type
C# oferece diversas formas de lidar com tipos em tempo de execução, especialmente útil quando lidamos com coleções de interfaces.

### 1. OfType<T> (LINQ)
Filtra os elementos de uma lista que podem ser convertidos para o tipo especificado. É a forma mais limpa de buscar implementações específicas.

    var fechadores = funcionarios.OfType<IFechadorPedido>().ToList();
    // Retorna apenas os objetos que implementam IFechadorPedido


### 2. Where com is
Uma alternativa manual ao OfType.
    
    var lista = funcionarios.Where(f => f is IFechadorPedido);


### 3. typeof vs GetType()
- typeof(IMeuTipo): Operador usado em tempo de compilação para obter o objeto Type.
- objeto.GetType(): Método usado em tempo de execução para descobrir o tipo real de uma instância.


# 🚀 Para Aprofundar
### Princípios SOLID com C#
- S (SRP): Uma classe deve ter apenas um motivo para mudar.
- O (OCP): Aberto para extensão, fechado para modificação.
- L (LSP): Subclasses devem poder substituir suas classes base sem quebrar a lógica.
- I (ISP): Segregação de interfaces (visto acima).
- D (DIP): Dependa de abstrações, não de implementações concretas.

### Implementação Padrão (Default Interface Methods): 
Introduzido no C# 8.0, permite que interfaces tenham uma implementação base. Isso ajuda a evoluir interfaces antigas sem quebrar as classes que já as implementam.

    public interface ILogger
    {
        void Log(string message);
        // Método com implementação padrão
        void LogError(string message) => Log($"ERRO: {message}");
    }