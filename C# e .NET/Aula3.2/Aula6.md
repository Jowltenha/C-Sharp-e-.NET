# Aula 3.2("6") - Assuntos cobertos: coleções, LINQ

## Coleções indexáveis: List:
A ***List<T>*** é uma lista dinâmica que cresce conforme necessário. Ela é indexável, o que significa que você pode acessar qualquer elemento diretamente pela sua posição (índice), começando do zero.
	
	List<string> frutas = new List<string> { "Maçã", "Banana" };

	frutas.Add("Laranja"); // Adiciona ao final
	
	string primeira = frutas[0]; // Acesso via índice: "Maçã"

## Coleções de pares chave/valor: Dictionary<TKey, TValue>:
Armazena dados em pares. Cada chave deve ser única e serve como um "índice personalizado" para encontrar um valor de forma extremamente rápida.

	var ddd = new Dictionary<int, string>();

	ddd.Add(11, "São Paulo");

	ddd[21] = "Rio de Janeiro";
	
	Console.WriteLine(ddd[11]); // Saída: São Paulo

## Quando usar coleções genéricas:
- Você deve usar coleções genéricas (do namespace System.Collections.Generic) sempre que souber o tipo de dado que vai armazenar.

- Segurança (Type Safety): Evita erros de runtime ao tentar inserir um tipo errado.

-  Performance: Evita o boxing/unboxing (conversão de tipos valiosos para objeto), tornando o código mais rápido.

## LINQ (Consulta Integrada à Linguagem) e consultas mais comuns:
O LINQ (Language Integrated Query) permite filtrar, ordenar e transformar dados de qualquer coleção usando uma sintaxe padronizada.

Consultas mais comuns:

- ***Where:*** Filtra elementos.

- ***OrderBy / OrderByDescending:*** Ordena os dados.

- ***Select:*** Projeta/Transforma os dados (ex: pegar apenas os nomes de uma lista de objetos).

- ***FirstOrDefaut:*** Pega o primeiro elemento ou retorna nulo se não achar nada.

## LINQ: Sintaxe de query (declarativa):
Assemelha-se muito ao SQL. É considerada mais legível para consultas complexas com múltiplos cruzamentos (joins).

	int[] numeros = { 1, 5, 8, 10, 15, 20 };
	
	var filtrados = from n in numeros
	                where n > 10
	                orderby n descending
	                select n;

## LINQ: Sintaxe de método (imperativa):
Usa métodos de extensão e expressões lambda (=>). É a mais utilizada no dia a dia por ser mais concisa e fácil de encadear.
	
	int[] numeros = { 1, 5, 8, 10, 15, 20 };
	
	var filtrados = numeros
	                .Where(n => n > 10)
	                .OrderByDescending(n => n);

# Para aprofundar:
Visão geral sobre coleções do .NET -> https://learn.microsoft.com/pt-br/dotnet/standard/collections/

Introdução a consultas LINQ -> https://learn.microsoft.com/pt-br/dotnet/csharp/linq/get-started/introduction-to-linq-queries

Todas as coleções Genéricas - System.Collections.Generic -> https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic?view=net-10.0

Todas as coleções não genéricas (Object) - System.Collections -> https://learn.microsoft.com/pt-br/dotnet/api/system.collections?view=net-10.0