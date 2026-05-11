// Cria um array de números inteiros
int[] numeros = { 1, 2, 3, 4, 5, 6 };


// LINQ usando sintaxe de consulta (query syntax)

// from n in numeros
// -> percorre cada número do array

// where n % 2 == 0
// -> filtra apenas números pares

// select n
// -> seleciona os números encontrados

var pares = from n in numeros
            where n % 2 == 0
            select n;


// Percorre os números pares encontrados
foreach (var num in pares)
{
    Console.WriteLine(num);
}



// Outra sintaxe usando Lambda
Console.WriteLine("Exemplo usando Lambda\n");


// Where = filtra elementos
// n => n % 2 == 0
// -> retorna apenas números pares

var pares2 = numeros.Where(n => n % 2 == 0);


// Percorre os resultados
foreach (var num in pares2)
{
    Console.WriteLine(num);
}