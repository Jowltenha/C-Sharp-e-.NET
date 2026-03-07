# Aula 2.1("3") - Assuntos cobertos: arrays, repetição, menu, enum:

# Uso de matrizes (arrays) 
--> https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/arrays

int[] numbers = new int[10]; // Todos valores são 0
string[] messages = new string [10]; // Todos os valores são nulos

## Matrizes unidimensionais, multidimensionais, e denteadas:

    // Matriz Unidimensional de 5 inteiros
    int[] array1 = new int[5];

    // Declara e atribuir os valores dos elementos da Matriz
    int[] array2= [1, 2, 3, 4, 5, 6]; 

    // Matriz bidimensional 
    int[,] multiDimensionalArray1 = new int[2, 3];
    
    // Declarar e definir os valores dos elementos da matriz.
    int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
    
    // Matriz Irregular
    int[][] jaggedArray = new int[6][];
    
    // Define os valores do primeiro array na estrutura de array denteado.
    jaggedArray[0] = [1, 2, 3, 4];


## Matrizes Unidimensionais:
#### -> Uma matriz unidimensional é uma sequência de elementos semelhantes. Você acessa um elemento por meio de seu índice.

    int[] array = new int[5]
    string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
    
    Console.WriteLine(weekDays[0]); //  Sun
    Console.WriteLine(weekDays[1]); // 	Mon
    Console.WriteLine(weekDays[2]); // 	Tue
    Console.WriteLine(weekDays[3]); // 	Wed
    Console.WriteLine(weekDays[4]); // 	Thu
    Console.WriteLine(weekDays[5]); // 	Fri
    Console.WriteLine(weekDays[6]); // 	Sat


## Matrizes multidimensionais


## Matrizes denteadas
#### Uma matriz irregular é uma matriz cujos elementos são matrizes, possivelmente de tamanhos diferentes. Às vezes, uma matriz denteada é chamada de uma "matriz de matrizes."

# Instrução for 

    for (int i = 0; i < 3; i++)
    {
        Console.Write(i); // 012
    }

# Instrução Foreach: ------------

    Span<int> numbers = [3, 14, 15, 92, 6];
    foreach (int number in numbers)
    {
        Console.Write($"{number} "); // 3 14 15 92 6
    }
 
# Instrução while: 

    int n = 0;
    while (n < 5)
    {
        Console.Write(n); // 01234
        n++;
    }

# Instrução do..while: 

    int n = 0;
    do
    {
        Console.Write(n); // 01234
        n++;
    } while (n < 5);

### Para aprofundar
### Operador de intervalo para matrizes
### Usando Enum como sinalizador de bits (múltiplos valores)