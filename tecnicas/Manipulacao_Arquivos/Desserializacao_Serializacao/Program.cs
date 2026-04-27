using System.Reflection.Metadata.Ecma335;
var pessoa = new Pessoa { Nome = "Maria", Idade = 21 };

//serializar
string json = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(json);
//desserialização
var jsonString = "{\"Nome\":\"João\",\"Idade\":25}";

Pessoa pessoaDess = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonString);
Console.WriteLine(pessoaDess.Nome);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    //Construtor padrão (sem argumentos obrigatório para a desserialização
    public Pessoa() { }

    public Pessoa (string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}