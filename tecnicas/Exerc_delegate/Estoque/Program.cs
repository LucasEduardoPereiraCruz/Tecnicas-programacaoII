using System;

class Estoque
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    // Delegate pré-definido
    public event Action<string, int> EstoqueBaixo;

    // Verifica se está baixo
    public void VerificarEstoque()
    {
        if (Quantidade < 5)
        {
            // Dispara o evento
            EstoqueBaixo?.Invoke(Nome, Quantidade);
        }
    }
}

class Alerta
{
    // método que será chamado quando o evento acontecer
    public void MostrarAlerta(string nome, int quantidade)
    {
        Console.WriteLine("ALERTA: " + nome + " com quantidade " + quantidade);
    }
}

class Program
{
    static void Main()
    {
        // cria o produto
        Estoque produto = new Estoque();
        // cria quem vai mostrar o alerta
        Alerta alerta = new Alerta();

        produto.Nome = "Mouse";
        produto.Quantidade = 10; // Quantidade inicial 

        // Se inscreve no evento
        produto.EstoqueBaixo += alerta.MostrarAlerta;

        // Simulando queda no estoque
        produto.Quantidade = 3; // Agora tenho 3 mouses
        // Verifica e dispara o evento
        produto.VerificarEstoque();

        // Espera tecla pra fechar
        Console.ReadKey();
    }
}

// ============== Se eu tivesse mais que 5, não aparece alerta nenhum ============== // 