// Importa o namespace que contém a classe ArrayList
using System.Collections;

// Cria um ArrayList com capacidade inicial de 5 elementos
ArrayList lista = new ArrayList(5);

// Cria outro ArrayList com capacidade inicial de 2 elementos
ArrayList listb = new(2);

// Adiciona a string "Maria" ao ArrayList
lista.Add("Maria");

// Adiciona um valor double ao ArrayList
// ArrayList aceita qualquer tipo de dado
lista.Add(1.65);

// Adiciona um valor booleano
lista.Add(true);

// Adiciona um valor nulo
lista.Add(null);

// Insere o valor 65 no índice 3 da lista
// Os elementos após esse índice são deslocados para frente
lista.Insert(3, 65);

// Cria um array de inteiros
int[] array1 = { 1, 2, 3 };

// Adiciona todos os elementos do array no final do ArrayList
lista.AddRange(array1);

// Insere os elementos do array a partir do índice 0
// Os itens antigos são deslocados
lista.InsertRange(0, array1);

// Remove o elemento "Maria" da lista
lista.Remove("Maria");

// Remove o elemento que está no índice 1
lista.RemoveAt(1);

// Remove 4 elementos começando pelo índice 2
lista.RemoveRange(2, 4);

// Percorre todos os elementos da lista
foreach (var dado in lista)
{
    // Exibe cada elemento no console
    Console.WriteLine(dado);
}

// Cria um ArrayList já inicializado com valores
var lista3 = new ArrayList() { "Maria", "Paulo", "Ana" };

// Ordena os elementos em ordem alfabética
lista3.Sort();

// Verifica se existe o elemento "a" dentro da lista
// OBS: diferencia maiúsculas e minúsculas
var res1 = lista3.Contains("a");

// Percorre a lista já ordenada
foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}

// Verifica o resultado do Contains
if (res1)
{
    Console.WriteLine("Contém");
}
else
{
    Console.WriteLine("Não contém");
}

// Remove todos os elementos da lista
lista3.Clear();

// Percorre a lista novamente
// Não irá mostrar nada pois a lista foi limpa
foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}