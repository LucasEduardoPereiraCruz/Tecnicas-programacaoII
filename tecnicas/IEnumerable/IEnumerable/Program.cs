// IEnumerable serve para percorrer coleções
// Ele NÃO possui métodos para alterar os dados diretamente

// Cria uma lista de strings
List<string> lista = new List<string>
{
    "Alice",
    "Maria",
    "Pedro"
};


// Cria um array de strings
string[] array =
{
    "Clara",
    "Marcelo"
};


// Cria um IEnumerable de strings
IEnumerable<string> Inomes = new List<string>
{
    "Clovis"
};



// Envia a lista para o método
ExibirNomes(lista);

// Envia o array para o método
ExibirNomes(array);

// Envia o IEnumerable para o método
ExibirNomes(Inomes);



// Método que recebe qualquer coleção IEnumerable
// Isso torna o método mais flexível
void ExibirNomes(IEnumerable<string> colecao)
{
    // Percorre todos os elementos
    foreach (var nome in colecao)
    {
        Console.WriteLine(nome);
    }
}