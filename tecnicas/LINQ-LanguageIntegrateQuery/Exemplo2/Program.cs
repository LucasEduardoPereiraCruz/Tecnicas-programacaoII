// Cria lista de nomes
List<string> nomes = new List<string>()
{
    "Ana",
    "Maria",
    "Paulo",
    "Pedro",
    "Lais",
    "Hugo"
};


// LINQ usando sintaxe de consulta

// from m in nomes
// -> percorre cada nome da lista

// where m.Contains("o")
// -> filtra nomes que possuem a letra "o"

// select m
// -> retorna os nomes encontrados

var resultado = from m in nomes
                where m.Contains("o")
                select m;


// Percorre os nomes filtrados
foreach (var nome in resultado)
{
    Console.WriteLine(nome);
}