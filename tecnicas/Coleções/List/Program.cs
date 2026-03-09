var list  = new List<string>();
list.Add("Laranja");
List<int> list2 = new();
var lista3 = new List<string>() 
{ "Brasil", "Portugal", "Espanha" };

List<Carro> carros = new List<Carro>();

carros.Add (new Carro("Fiat", "Toro", 2026));

public class Carro
{
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int Ano { get; set; }
}

