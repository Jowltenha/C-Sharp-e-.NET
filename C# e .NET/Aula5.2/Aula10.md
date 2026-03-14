# Aula 5.2("10") - Assuntos cobertos: Programação orientada a objetos (abstração)

# Abstração em .NET
### 1. O que é Abstração?

É um dos pilares da POO. Imagine um controle remoto: você sabe que o botão "Power" liga a TV, mas não precisa entender o circuito eletrônico interno para usá-lo. No código, usamos classes e métodos abstratos para criar esses modelos mentais.

### 2. abstract para Classes

Uma classe marcada como abstract é uma classe incompleta.

- Não pode ser instanciada: Você não pode dar um new ClasseAbstrata().

- Serve como Molde: Ela existe apenas para ser herdada por outras classes.

- Pode ter lógica: Diferente de uma Interface, uma classe abstrata pode ter métodos com implementação (código real) e campos.

### 3. abstract para Métodos e Membros

Quando você define um método como abstract, você está criando uma "promessa":

- Sem corpo: O método não tem { }, termina apenas com ;.

- Obrigação: Qualquer classe filha deve implementar esse método (usando override), a menos que a filha também seja abstrata.

- Contrato de Comportamento: Garante que todas as subclasses tenham aquela funcionalidade, mas cada uma do seu jeito.
***
    public abstract class Animal 
    {
        public abstract void EmitirSom(); // Cada animal faz de um jeito
        public void Dormir() => Console.WriteLine("Zzz..."); // Todos dormem igual
    }

# Ecossistema Awesome .NET
Para não reinventar a roda, a comunidade mantém listas curadas de ferramentas e bibliotecas de alta qualidade.

## .NET Awesome & .NET Core Awesome
Esses termos geralmente se referem a repositórios no GitHub (como o famoso quozd/awesome-dotnet) que catalogam o que há de melhor no ecossistema:

- ORM / Dados: Entity Framework Core, Dapper (Performance).

- Testes: xUnit, FluentAssertions, Bogus (para dados fakes).

- Serialização: System.Text.Json, Newtonsoft.Json.

- Logging: Serilog, NLog.

- API / Documentação: Swagger (Swashbuckle), Refit (para consumir APIs).

- Resiliência: Polly (circuit breaker, retries).

- Mapeamento: AutoMapper, Mapster.

# 📚 Para Aprofundar
### Abstração vs. Interface
Um ponto comum de confusão. Use Classe Abstrata quando os objetos compartilham uma identidade (ex: "Cachorro é um Animal"). Use Interface quando compartilham apenas uma capacidade (ex: "Carro é de um tipo, mas é IVeiculo).

### Ferramentas Essenciais
- BenchmarkDotNet: Para medir a performance do seu código com precisão científica.

- LINQPad: Uma ferramenta incrível para testar queries e trechos de código C# rapidamente sem criar um projeto inteiro.