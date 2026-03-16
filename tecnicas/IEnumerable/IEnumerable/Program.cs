// Não permite alteração na coleção 
List<string> lista = new List<string> { "Alice", "Maria", "Pedro"};
string[] array = { "Clara", "Marcelo" };
IEnumerable<string> Inomes = new List<string> { "Clovis" };

ExibirNomes(lista);
ExibirNomes(array);
ExibirNomes(Inomes);


void ExibirNomes(IEnumerable<string> colecao)
{
    foreach (var nome in colecao)
    {
        Console.WriteLine(nome);
    }
}