using System;


// Classe Botao
class Botao
{
    // Delegate do evento
    public delegate void CliqueHandler();


    // Evento
    public event CliqueHandler Clique;


    // Método que simula clique
    public void SimularClique()
    {
        // Dispara evento
        Clique?.Invoke();
    }
}




// Classe que conta cliques
class ContadorCliques
{
    // Variável contador
    int contador = 0;


    // Método executado ao clicar
    public void Contar()
    {
        // Incrementa contador
        contador++;

        // Exibe quantidade
        Console.WriteLine(
            "Quantidade de cliques: " + contador
        );
    }
}




// Main do programa
class Program
{
    static void Main()
    {
        // Cria botão
        Botao botao = new Botao();

        // Cria contador
        ContadorCliques contador = new ContadorCliques();


        // Inscreve método no evento
        botao.Clique += contador.Contar;


        // Simula vários cliques
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();


        // Aguarda tecla
        Console.ReadKey();
    }
}