# Aula 4.1("7") - Assuntos cobertos: Programação orientada a objetos (encapsulamento)

# POO - Encapsulamento 1:
O encapsulamento é o "escudo" da computação. Ele consiste em esconder os detalhes internos de funcionamento de um objeto e expor apenas o que é estritamente necessário através de uma interface pública.

Objetivo: Impedir que o estado interno de um objeto seja corrompido por acessos externos indevidos.

    public class ContaBancaria {
        private decimal _saldo; // Ninguém de fora altera o saldo diretamente
    
        public void Depositar(decimal valor) {
            if (valor > 0) _saldo += valor; // A própria classe controla a regra
        }
    }

# POO - Encapsulamento 2 (deviq):
Aqui o foco é a integridade. Encapsulamento não é apenas usar private, mas garantir que o objeto nunca esteja em um estado inválido. No design defensivo, você valida os dados no momento em que eles tentam entrar no objeto (construtores e métodos).

Conceito Chave: O objeto é responsável por manter sua própria validade o tempo todo.

# Padrão Modelo de domínio:
Neste padrão, as classes de negócio (Entidades) são "ricas". Elas contêm tanto os dados quanto o comportamento (lógica) relacionado a esses dados.

Onde fica a lógica? Dentro da própria classe de domínio.

Vantagem: O código é mais expressivo e segue as regras de negócio de forma centralizada.

Exemplo: Uma classe Pedido que tem um método CalcularTotal() e AdicionarItem().

# Padrão (ou antipadrão) Modelo de domínio anêmico:
Ocorre quando as classes de domínio contêm apenas dados (propriedades get e set) e nenhuma lógica de negócio. A lógica acaba sendo "sequestrada" por classes de serviço externas.

Por que é considerado antipadrão? Porque viola o encapsulamento. As classes tornam-se apenas sacos de dados (DTOs disfarçados), e a lógica fica espalhada em diversos serviços, dificultando a manutenção.

Exemplo: Uma classe Cliente que só tem propriedades, e um ClienteService que decide se o cliente pode comprar ou não.

# Para aprofundar: 
## Princípios populares de desenvolvimento - Regra do escoteiro
Inspirada no lema dos escoteiros: "Deixe o acampamento mais limpo do que você o encontrou". No desenvolvimento, isso significa que, ao mexer em um arquivo para corrigir um bug ou adicionar uma feature, você deve aproveitar para fazer uma pequena melhoria no código ao redor.

Ação: Renomear uma variável confusa, remover um comentário inútil ou simplificar um if enquanto você está naquela classe.

Resultado: O código melhora gradualmente com o tempo, em vez de apodrecer.

## Princípios populares de desenvolvimento - KISS (Keep It Simple, Stupid)
O princípio prega que a maioria dos sistemas funciona melhor se forem mantidos simples do que se tornarem complexos. Evite "overengineering" (engenharia excessiva) ou o uso de padrões complexos onde uma solução simples resolve.

Filosofia: Se você consegue resolver um problema com 5 linhas de código legível, não use um padrão de projeto complexo que exija 50 linhas.

Foco: Legibilidade e facilidade de manutenção.

## Princípios populares de desenvolvimento - YAGNI (You Ain't Gonna Need It - Você não vai precisar)
"Você não vai precisar disso". Este princípio diz para não adicionar funcionalidades ou abstrações baseadas em uma suposição de que "no futuro talvez precisemos".

O Erro comum: Criar uma estrutura genérica para suportar 10 tipos de pagamento quando, hoje, o cliente só usa 1.

Benefício: Economiza tempo de desenvolvimento e evita que o sistema fique inflado com código morto ou desnecessário.

## Princípios populares de desenvolvimento - DRY (Don't Repeat Yourself)
"Não se repita". Cada pedaço de conhecimento ou lógica dentro de um sistema deve ter uma representação única e inequívoca. Se você tem o mesmo cálculo de imposto em três lugares diferentes, você violou o DRY.

Ação: Extrair lógica repetida para um método ou classe centralizada.

Cuidado: Não leve o DRY ao extremo (o chamado "Dry-drunk"), pois tentar unir códigos que são parecidos apenas por coincidência pode criar dependências ruins.