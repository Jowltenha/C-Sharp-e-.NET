# Aula 5.1("9") - Assuntos cobertos: Programação orientada a objetos (polimorfismo)

# 🧩 Polimorfismo e Herança em .NET
O polimorfismo (do grego "muitas formas") permite que objetos de diferentes classes sejam tratados como objetos de uma classe base comum.

## 1. Membros Virtuais (virtual)
Na classe base, usamos a palavra-chave virtual para sinalizar que um método, propriedade ou evento pode ser modificado pelas classes que a herdarem. É um convite à especialização.

## 2. Sobrescrita de Membros (override)
Na classe derivada (filha), usamos o modificador override para fornecer uma nova implementação ao membro marcado como virtual. Isso garante que, mesmo chamando o método a partir de uma referência da classe base, a versão "especializada" seja executada.

## 3. System.Object e Herança Implícita
No .NET, toda classe herda implicitamente de System.Object. Se você criar public class Pessoa {}, ela já nasce com métodos como Equals(), GetHashCode() e ToString().

## 4. O Método ToString()
É um dos usos mais comuns de polimorfismo. Por padrão, ele retorna o nome completo do tipo (Namespace.Classe). Ao fazer o override dele, você define uma representação textual útil para o objeto.

    public override string ToString() 
    {
        return $"Nome: {this.Nome}, Idade: {this.Idade}";
    }

## Clean Architecture e Evolução de Código
A Clean Architecture foca na separação de preocupações, garantindo que as regras de negócio não dependam de frameworks, bancos de dados ou UI.

## Estágios de uma Arquitetura Evolucionária
1. Um projeto não precisa nascer complexo. Ele pode evoluir conforme a necessidade:

2. Monolito Simples: Tudo em um único projeto (UI + Lógica + Dados). Ideal para MVPs.

3. Separação por Camadas (Layered): Divisão clara entre Core, Application e Infrastructure.

4. Domínio Rico (DDD): Foco total nas regras de negócio dentro das entidades, isolando a complexidade.

5. Microsserviços/Modular: Quando a escala exige que partes do sistema sejam implantadas de forma independente.


## 📚 Para Aprofundar e Praticar
#### Modelagem de Objetos para Problemas Reais

- Sistema de Pagamentos: Use polimorfismo para tratar CartaoCredito, Boleto e Pix sob uma base MetodoPagamento.

- Gestão de Fretes: Diferentes transportadoras implementando a mesma interface de cálculo, mas com lógicas internas distintas.

#### Exemplos de Projetos Reais Completos
Para ver a teoria na prática, recomendo explorar estes repositórios no GitHub que são referências na comunidade .NET:

- eShopOnWeb: Exemplo oficial da Microsoft de uma aplicação web monolítica usando Clean Architecture.

- CleanArchitecture (ardalis): Um template popular que mostra a organização correta de pastas e dependências.