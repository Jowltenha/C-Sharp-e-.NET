# Aula 4.2("8") -Assuntos cobertos: Programação orientada a objetos (herança)

# O que é uma herança - relacionamento do tipo “é um” (ex: garçon "é um" funcionário)
A herança permite que uma classe herde características (atributos e métodos) de outra. O teste para saber se a herança é adequada é a frase "é um". Se a frase fizer sentido, a herança é semanticamente correta.

- Exemplo: Um Garcom é um Funcionario. Uma Moto é um Veiculo.

- Regra: O que vale para a classe pai, deve valer para a classe filha.

# Conceito de classe base e classe derivada
Classe Base (Pai/Superclasse): É a classe que fornece os membros originais. Ela é o modelo mais genérico.

Classe Derivada (Filha/Subclasse): É a classe que herda da base. Ela pode adicionar novos comportamentos ou modificar os existentes.

    public class Funcionario { // Classe Base
        public string Nome { get; set; }
    }
    
    public class Garcom : Funcionario { // Classe Derivada
        public int NumeroMesas { get; set; }
    }

# Palavra-chave 'base' para herança explícita de construtor (não existe herança implícita de construtor)
Diferente de métodos e propriedades, construtores não são herdados. Se a classe base tem um construtor que recebe parâmetros, a classe derivada deve chamar esse construtor explicitamente usando a palavra-chave : base().

    public class Funcionario {
        public Funcionario(string nome) { lógica }
    }
    
    public class Garcom : Funcionario {
        // Chama o construtor da base passando o nome
        public Garcom(string nome) : base(nome) { } 
    }

# Visibilidade 'protected'
O modificador protected é o meio-termo entre o public e o private.

- Privado (private): Só a própria classe vê.

- Protegido (protected): A própria classe e as suas classes derivadas podem ver, mas o mundo exterior (quem instancia o objeto) não.

# Palavra-chave 'sealed' para impedir herança
A palavra sealed (selada) impede que outras classes herdem dela. É útil para garantir que o comportamento da sua classe não seja alterado ou estendido por terceiros, ou por razões de performance.

    public sealed class SistemaSeguranca { }
    
    // public class Tentativa : SistemaSeguranca { } // ERRO de compilação!
    

# Sobrecarregando métodos

Para que uma classe filha possa alterar um comportamento da classe pai, usamos o polimorfismo com as palavras-chave virtual (na base) e override (na derivada).
Nota: No C#, usamos "override" para sobrescrever o comportamento. O termo "sobrecarga" geralmente refere-se a métodos com o mesmo nome na mesma classe, mas com parâmetros diferentes.

    public class Funcionario {
        public virtual void Trabalhar() => Console.WriteLine("Batendo ponto...");
    }
    
    public class Garcom : Funcionario {
        public override void Trabalhar() => Console.WriteLine("Atendendo mesas...");
    }