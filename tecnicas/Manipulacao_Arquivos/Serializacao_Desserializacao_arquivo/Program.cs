// Importa namespace relacionado a metadata
using System.Reflection.Metadata.Ecma335;

// Importa biblioteca para trabalhar com JSON
using System.Text.Json;


// Caminho/nome do arquivo JSON
var caminho = "pessoas.json";



// Cria lista de pessoas
List<Pessoa> listaPessoas = new List<Pessoa>
{
    new Pessoa {Nome = "Ana", Idade = 20},
    new Pessoa {Nome = "Carlos", Idade = 21},
    new Pessoa {Nome = "Sandra", Idade = 19},
};



// SERIALIZAÇÃO EM ARQUIVO

// Verifica se o arquivo NÃO existe
if (!File.Exists(caminho))
{
    // Converte lista para JSON formatado
    string jsonString = JsonSerializer.Serialize(
        listaPessoas,

        // Deixa JSON identado/bonito
        new JsonSerializerOptions
        {
            WriteIndented = true
        }
    );

    // Cria arquivo e grava conteúdo JSON
    File.WriteAllText(caminho, jsonString);

    // Exibe mensagem
    Console.WriteLine("Arquivo json gravado");
}




// DESSERIALIZAÇÃO

// OBS:
// Aqui provavelmente deveria ser:
// if (File.Exists(caminho))
// pois para ler o arquivo ele precisa existir

if (!File.Exists(caminho))
{
    // Lê todo conteúdo do arquivo
    string conteudo = File.ReadAllText(caminho);


    // Converte JSON em lista de pessoas
    List<Pessoa> listaConteudo = JsonSerializer
        .Deserialize<List<Pessoa>>(conteudo);


    Console.WriteLine("Lista de Pessoas");


    // Percorre lista desserializada
    foreach (var Pes in listaConteudo)
    {
        Console.WriteLine(
            $"Nome: {Pes.Nome} - Idade: {Pes}"
        );
    }
}





// Classe Pessoa
public class Pessoa
{
    // Nome
    public string Nome { get; set; }

    // Idade
    public int Idade { get; set; }


    // Construtor padrão
    // Necessário para desserialização
    public Pessoa() { }


    // Construtor com parâmetros
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}