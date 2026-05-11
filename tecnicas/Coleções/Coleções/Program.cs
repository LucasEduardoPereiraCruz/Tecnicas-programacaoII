// Array = tamanho fixo e aceita apenas um tipo de dado

// Cria um array de inteiros com 10 posições
int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Declara um array sem inicializar
int[] valores;

// Inicializa o array com 2 posições
valores = new int[2] { 20, 10 };

// Cria um array de strings
string[] nomes = new string[5]
{
    "Maria",
    "Paulo",
    "Pedro",
    "Silvia",
    "Carolina"
};

// Inverte a ordem dos elementos do array numeros
Array.Reverse(numeros);

// Ordena os nomes em ordem alfabética
Array.Sort(nomes);

// Procura "Pedro" no array
// Retorna o índice onde ele foi encontrado
int indice = Array.BinarySearch(nomes, "Pedro");

// Exibe o índice encontrado
Console.WriteLine($"Encontrou Pedro no índice {indice}");

// Percorre o array nomes
foreach (var dado in nomes)
{
    Console.WriteLine(dado);
}

// Percorre o array valores usando for
for (int x = 0; x < 2; x++)
{
    Console.WriteLine(valores[x]);
}

// Declara uma matriz bidimensional
int[,] Mat1;

// Cria uma matriz com 2 linhas e 3 colunas
Mat1 = new int[2, 3];

// Define valor da linha 0 coluna 0
Mat1[0, 0] = 1;

// Cria e inicializa uma matriz 3x2
int[,] Mat2 = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

// Percorre as linhas da matriz
for (int lin = 0; lin < Mat2.GetLength(0); lin++) // O 0 significa que ele quer pegar a quantidade de linhas da matriz.
{
    // Percorre as colunas da matriz
    for (int col = 0; col < Mat2.GetLength(1); col++) // O 1 significa que ele quer pegar a quantidade de colunas.
    {
        // Exibe o valor da posição atual
        Console.WriteLine(Mat2[lin, col]);
    }
}

// Outra forma de percorrer a matriz
foreach (var dado in Mat2)
{
    Console.WriteLine(dado);
}