Aula 1.2("2") - Exercicios, conversões, if-else, switch, erros, operações aritméticas, datetime

var ---> implicitamente tipada, o tipo é definido pelo valor atribuído;
Recomendado usar os tipos explícitos para melhor legibilidade e manutenção do código;

Intruções de nivel superior(top-level statements):
	Syntax Sugar: Um atalho para simplificar a escrita de programas simples;

using System; // Importa o namespace System para usar suas classes e métodos
Int32, Int64, Double, String, etc. são aliases para os tipos primitivos do C#
---- REVISAR MELHOR ------------------------------------------------------------------------------------

Conversões:
	Conversão implícita: Ocorre quando o tipo de destino pode armazenar o valor do tipo de origem sem perda de dados;
	Conversão explícita (casting): Necessária quando há risco de perda de dados ou quando os tipos não são compatíveis;

		int a = 10;
		double b = a; // Conversão implícita
		double c = 3.14;
		int d = (int)c; // Conversão explícita (casting)

------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Snake_case: Convenção de nomenclatura onde as palavras são separadas por underscores (_);
CamelCase: Convenção de nomenclatura onde a primeira letra de cada palavra é maiúscula, exceto a primeira palavra; ---> variaveis, parametros, campos privados, etc.
PascalCase: Convenção de nomenclatura onde a primeira letra de cada palavra é maiúscula, incluindo a primeira palavra; ---> metodos, classes, propriedades, etc.


------------------------------------------------------------------------------------------------------------------------------------------------------------------------
var salarioInput = Console.ReadLine(); // Lê a entrada do usuário como string
double salario = 0.00; // Inicializa a variável salario com um valor padrão
double.TryParse(salarioInput, out salario); // Tenta converter a string para double, armazenando o resultado em salario, não retorna erro 
se a conversão falhar, apenas mantém salario como 0.00, retorna um booleano indicando se a conversão foi bem-sucedida ou não.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

if-else:
	Permite executar blocos de código diferentes com base em condições;

		int idade = 20;
		if (idade >= 18)
		{
			Console.WriteLine("Você é maior de idade.");
		}
		else
		{
			Console.WriteLine("Você é menor de idade.");
		}

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Operadores aritméticos:
	+ (adição), - (subtração), * (multiplicação), / (divisão), % (módulo);

		int x = 10;
		int y = 3;
		int soma = x + y; // 13
		int subtracao = x - y; // 7
		int multiplicacao = x * y; // 30
		int divisao = x / y; // 3
		int modulo = x % y; // 1

Operadores unários ++, -- e -
Operadores binários *, /, + e -
Atribuição composta de operadores *=, /=, += e -= (C# 14 e posterior)

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Operadores de comparação:
	== (igualdade), != (diferença), > (maior que), < (menor que), >= (maior ou igual a), <= (menor ou igual a);

		int a = 5;
		int b = 10;
		bool resultado = a < b; // true

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Operadores lógicos:
	&& (AND), || (OR), ! (NOT);

		bool condicao1 = true;
		bool condicao2 = false;
		bool resultado = condicao1 && condicao2; // false

------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Manipulando datas e horas com DateTime:

	DateTime dataAtual = DateTime.Now; // Obtém a data e hora atual

	DateTime dataEspecifica = new DateTime(2024, 6, 1); // Cria uma data específica (1 de junho de 2024)
	
	TimeSpan diferenca = dataAtual - dataEspecifica; // Calcula a diferença entre duas datas
	
	Console.WriteLine($"Dias desde {dataEspecifica.ToShortDateString()}: {diferenca.Days}"); // Exibe a diferença em dias