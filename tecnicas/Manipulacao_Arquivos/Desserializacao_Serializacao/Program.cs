// Importa namespace relacionado a metadata
// (nesse código ele não está sendo utilizado)
using System.Reflection.Metadata.Ecma335;


// Cria um objeto Pessoa
var pessoa = new Pessoa
{
    Nome = "Maria",
    Idade = 21
};



// SERIALIZAÇÃO
// Converte objeto C# para JSON
string json = System.Text.Json.JsonSerializer.Serialize(pessoa);


// Exibe JSON gerado
Console.WriteLine(json);



// DESSERIALIZAÇÃO

// String JSON
var jsonString = "{\"Nome\":\"João\",\"Idade\":25}";


// Converte JSON para objeto Pessoa
Pessoa pessoaDess = System.Text.Json.JsonSerializer
    .Deserialize<Pessoa>(jsonString);


// Exibe nome do objeto desserializado
Console.WriteLine(pessoaDess.Nome);




// Classe Pessoa
public class Pessoa
{
    // Nome da pessoa
    public string Nome { get; set; }

    // Idade da pessoa
    public int Idade { get; set; }


    // Construtor vazio
    // Necessário para desserialização
    public Pessoa() { }


    // Construtor com parâmetros
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}