# Aula 3.1("5") - Assuntos cobertos: C# avançado

# Tipos de referência anuláveis:
Introduzidos para evitar o famoso erro NullReferenceException. Ao ativar esse recurso, o compilador diferencia tipos que não podem ser nulos de tipos que podem.

	string? nomePodeSerNulo = null; // Válido
	string nomeObrigatorio = "Infnet"; // Se tentar atribuir null, o compilador avisa

# Parâmetros Nomeados:
Permitem que você passe argumentos para um método especificando o nome do parâmetro, em vez de depender apenas da ordem. Isso aumenta muito a legibilidade do código.

***Vantagem:*** Você sabe exatamente o que cada valor representa sem precisar abrir a definição do método.

	void CriarUsuario(string nome, int idade) { }
	
	// Chamada com parâmetros nomeados
	CriarUsuario(idade: 25, nome: "Ana");

# Parâmetros Opcionais:
Permitem definir um valor padrão para um parâmetro na assinatura do método. Se o chamador não fornecer um valor, o padrão é usado.

***Regra:*** Devem ser colocados ao final da lista de parâmetros.

	void Incrementar(int valor, int passo = 1) { }
	
	Incrementar(10); // Passo será 1
	Incrementar(10, 5); // Passo será 5

# Sobrecarga de Métodos (Overloading):
É a capacidade de definir vários métodos com o mesmo nome, mas com assinaturas diferentes (diferentes tipos ou quantidades de parâmetros).

***Utilidade:*** Oferecer várias formas de executar uma ação similar (ex: Calcular(int x) e Calcular(double x)).

	void Log(string mensagem) { }
	void Log(int erroCodigo) { }
	void Log(string mensagem, Exception ex) { }

# Métodos de Extensão (Extension Methods):
Permitem "adicionar" métodos a tipos existentes sem modificar o código-fonte original ou criar um novo tipo derivado. Eles são definidos como métodos estáticos em classes estáticas, usando a palavra-chave this.

	public static class StringExtensions {
	    public static bool TemEspaco(this string texto) => texto.Contains(" ");
	}
	
	// Uso:
	string frase = "Olá Mundo";
	bool resultado = frase.TemEspaco();

# Arrow Function / Expression Body Definition:
Uma sintaxe curta para membros que contêm apenas uma expressão. Em vez de abrir chaves e usar return, utiliza-se o operador =>.

	public int Dobro(int n) => n * 2;

# Membros Estáticos (Static Props e Methods):
Pertencem à classe em si e não a uma instância específica (objeto). Você os acessa diretamente pelo nome da classe.

	public class Configuracao {
	    public static string Versao = "1.0.0";
	}
	
	// Uso:
	Console.WriteLine(Configuracao.Versao);

# Operador Ternário (?:):
Uma forma compacta de escrever uma estrutura if-else. Ele avalia uma condição booleana e retorna um de dois valores.

	int idade = 18;
	string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";


# Para aprofundamento:

- https://github.com/thangchung/clean-code-dotnet

- https://github.com/maniero/SOpt/blob/master/CSharp/Conceptual.md