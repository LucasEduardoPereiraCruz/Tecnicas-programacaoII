// Cria uma lista de strings
// List é tipada e cresce dinamicamente
var list = new List<string>();

// Adiciona um item na lista
list.Add("Laranja");

// Cria uma lista de inteiros
List<int> list2 = new();

// Cria uma lista já inicializada
var lista3 = new List<string>()
{
    "Brasil",
    "Portugal",
    "Espanha"
};

// Cria uma lista do tipo Carro
// Só aceita objetos da classe Carro
List<Carro> carros = new List<Carro>();

// Adiciona um novo objeto Carro na lista
carros.Add(new Carro("Fiat", "Toro", 2026));

// Classe Carro
public class Carro
{
    // Método construtor
    // Executa automaticamente ao criar um objeto
    public Carro(string marca, string modelo, int ano)
    {
        // Atribui o valor recebido para a propriedade Marca
        Marca = marca;

        // Atribui o valor recebido para a propriedade Modelo
        Modelo = modelo;

        // Atribui o valor recebido para a propriedade Ano
        Ano = ano;
    }

    // Propriedade Marca
    // ? indica que pode receber null
    public string? Marca { get; set; }

    // Propriedade Modelo
    public string? Modelo { get; set; }

    // Propriedade Ano
    public int Ano { get; set; }
}

