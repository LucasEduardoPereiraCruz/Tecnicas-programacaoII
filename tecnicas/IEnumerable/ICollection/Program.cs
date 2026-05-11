// ICollection herda de IEnumerable
// Porém ICollection permite alterar a coleção (Add, Remove, etc)

// Cria uma coleção de strings usando ICollection
ICollection<string> nomes = new List<string>
{
    "Selma",
    "Paulo"
};

// Adiciona um novo item na coleção
nomes.Add("Maria");


// Cria um array com o mesmo tamanho da coleção
string[] array = new string[nomes.Count];


// Copia os elementos da coleção para o array
// 0 = índice inicial do array
nomes.CopyTo(array, 0);



// Percorre o array copiado
foreach (var nome in array)
{
    Console.WriteLine(nome);
}



// Percorre a coleção original
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}