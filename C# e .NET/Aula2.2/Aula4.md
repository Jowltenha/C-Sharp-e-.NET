# Aula 2.2("4") - Assuntos cobertos: Programação orientada a objetos (introdução)

# Classe - definição de um tipo
 As classes são declaradas usando a palavra-chave class, seguida por um identificador exclusivo, conforme mostrado no exemplo a seguir:

	public class Customer
	{
		// Campos, propriedades, métodos e eventos vão aqui...
	}

## Herança de classe
As classes dão suporte completo à herança, uma característica fundamental da programação orientada a objetos. Quando você cria uma classe, é possível herdar de qualquer outra classe que não esteja definida como sealed. Outras classes podem herdar de sua classe e substituir métodos virtuais de classe. Além disso, você pode implementar uma ou mais interfaces.

	public class Manager : Employee
	{
		// Os campos, propriedades, métodos e eventos do funcionário são herdados
		// Os campos, propriedades, métodos e eventos do novo gerente vão aqui...
	}


# Objeto - instância de tipos
Um objeto é basicamente um bloco de memória alocado e configurado de acordo com o blueprint. Um programa pode criar muitos objetos da mesma classe. Os objetos também são chamados de instâncias e podem ser armazenados em uma variável nomeada ou em uma matriz ou coleção. 


----> Revisar
## Instâncias Struct vs. Instâncias de classe
Como as classes são tipos de referência, uma variável de um objeto de classe contém uma referência ao endereço do objeto no heap gerenciado. Se uma segunda variável do mesmo tipo for atribuída à primeira variável, ambas as variáveis se referirão ao objeto nesse endereço. Este ponto é discutido com mais detalhes mais adiante neste artigo.

---->


# Níveis de acessibilidade
Use os modificadores de acesso, public protected ou internal especifique private um dos seguintes níveis de acessibilidade declarados para membros.

	public: o acesso não é restrito.
	protected: o acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
	internal: o acesso é limitado ao assembly atual.
	protected internal: o acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.
	private: o acesso é limitado ao tipo recipiente.
	private protected: o acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual.

# Método
Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e especificando os argumentos de método necessários. No C#, todas as instruções executadas são realizadas no contexto de um método.
	

	abstract class Motorcycle
	{	
		// Anyone can call this.
		public void StartEngine() {/* Method statements here */ }

		// Only derived classes can call this.
		protected void AddGas(int gallons) { /* Method statements here */ }

		// Derived classes can override the base class implementation.
		public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

		// Derived classes must implement this.
		public abstract double GetTopSpeed();
	}

# Campo
Um campo é uma variável de qualquer tipo que é declarado diretamente em uma classe ou struct. Os campos são membros do tipo que os contém.

# Propriedades auto implementadas
Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo de dados. As propriedades aparecem como membros de dados públicos, mas são implementadas como métodos especiais chamados acessadores. Esse recurso permite que os chamadores acessem dados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos dados. A sintaxe para atributos é uma extensão natural para os campos de dados. Um campo define um local de armazenamento:

	public class Person
	{
		public string? FirstName;

		// Omitted for brevity.
	}

## Propriedades implementadas automaticamente
Uma definição de propriedade contém declarações para um acessador get e set que recupera e atribui o valor dessa propriedade:
	
	public class Person
	{
	    public string? FirstName { get; set; }
	    // Omitted for brevity.
	}

# Construtor
# Lançando exceções para valores inválidos (string.IsNullOrWhiteSpace e throw new)
# Tratamento de erros com try-catch

# Para aprofundar
## Exceções mais comuns (tanto para capturar, quanto para utilizar)
## Classes parciais
## Inicializando objetos (4 formas diferentes)
## Struct para pequenos tipos de dados com pouco comportamento (imutáveis)
## Record para tipos focados em armazenamento de dados sem comportamento