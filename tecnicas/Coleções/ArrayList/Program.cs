using System.Collections;

ArrayList lista = new ArrayList(5);
ArrayList listb = new (2);
lista.Add("Maria");
lista.Add(1.65);
lista.Add(true);
lista.Add(null);
lista.Insert(3, 65); // Acrescenta um item na sua lista, no índice específicado - 3

int[] array1 = { 1, 2, 3 };
// Add uma coleção no final do arraylist 
lista.AddRange(array1);
// Add uma coleção a partir do indice especificado 
lista.InsertRange(0, array1); 

// Remove - remove o elemento específico da lista da ArrayList
lista.Remove("Maria");

// RemoveAt - remove um item específicado 
lista.RemoveAt(1);

// RemoveRange - iniciar o remove de um indice e a partir dele 
lista.RemoveRange(2, 4);


foreach(var dado in lista)
{
    Console.WriteLine(dado);
}

var lista3 = new ArrayList() { "Maria", "Paulo", "Ana" }; 
lista3.Sort();
var res1 = lista3.Contains("a");

foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}
if (res1)
{
    Console.WriteLine("Contém");
}
else
{
    Console.WriteLine("Não contém");
}
lista3.Clear();
foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}