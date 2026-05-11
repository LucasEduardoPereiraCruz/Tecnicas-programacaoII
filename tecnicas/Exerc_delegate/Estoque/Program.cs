using System;


// Classe Estoque
class Estoque
{
    // Nome do produto
    public string Nome { get; set; }

    // Quantidade em estoque
    public int Quantidade { get; set; }


    // Evento usando Action
    // Action<string, int> significa:
    // método sem retorno que recebe:
    // string + int
    public event Action<string, int> EstoqueBaixo;


    // Método que verifica estoque
    public void VerificarEstoque()
    {
        // Verifica se estoque está baixo
        if (Quantidade < 5)
        {
            // Dispara evento
            EstoqueBaixo?.Invoke(Nome, Quantidade);
        }
    }
}




// Classe responsável pelo alerta
class Alerta
{
    // Método executado quando evento acontecer
    public void MostrarAlerta(string nome, int quantidade)
    {
        Console.WriteLine(
            "ALERTA: " + nome + " com quantidade " + quantidade
        );
    }
}




class Program
{
    static void Main()
    {
        // Cria produto
        Estoque produto = new Estoque();

        // Cria alerta
        Alerta alerta = new Alerta();


        // Define nome do produto
        produto.Nome = "Mouse";

        // Define quantidade inicial
        produto.Quantidade = 10;


        // Inscreve método no evento
        produto.EstoqueBaixo += alerta.MostrarAlerta;


        // Simula redução do estoque
        produto.Quantidade = 3;


        // Verifica estoque
        produto.VerificarEstoque();


        // Aguarda tecla
        Console.ReadKey();
    }
}


// Se estoque for maior ou igual a 5,
// nenhum alerta será exibido