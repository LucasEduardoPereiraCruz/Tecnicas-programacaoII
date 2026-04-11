using System;

class Botao
{
    // Delegate do evento 
    public delegate void CliqueHandler();

    // Evento
    public event CliqueHandler Clique; 

    // Método
    public void SimularClique()
    {
        Clique?.Invoke();
    }
}

class ContadorCliques
{
    int contador = 0;

    public void Contar()
    {
        contador++;
        Console.WriteLine("Quantidade de cliques: " + contador);
    }
}

// Main para ligar tudo 
class Program
{
    static void Main()
    {
        Botao botao = new Botao();
        ContadorCliques contador = new ContadorCliques();

        // Se inscreve no evento 
        botao.Clique += contador.Contar;

        // Simulando cliques
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();

        Console.ReadKey();
    }
}