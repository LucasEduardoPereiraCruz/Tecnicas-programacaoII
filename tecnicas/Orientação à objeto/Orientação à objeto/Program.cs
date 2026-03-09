// See https://aka.ms/new-console-template for more information
using Orientação_à_objeto;

Console.WriteLine("Hello, World!");


//Usando 


Produto prod1 = new Produto();
prod1.Nome = "Caderno";
prod1.Preco = 50.90;


Produto prod2 = new Produto("Lápis", 1.50);


//obj prod1
Console.WriteLine("Nome: " + prod1.Nome);  // "cw" atalho para console writeline
Console.WriteLine($"Preço: {prod1.Preco}");

//obj prod2
Console.WriteLine("Nome: " + prod2.Nome);  // "cw" atalho para console writeline
Console.WriteLine($"Preço: {prod2.Preco}");

// objeto de Produto2
Produto2 prod3 = new("Borracha", 4.60, 100);
prod3.Exibir();

Console.ReadKey(); // Pausar o programa até que o usuário pressione uma tecla
// Declarando 

public class Produto
{

    public Produto(){} // Construtor padrão que não recebe parâmetros 

    public Produto(string nome, double Preco) // construtor atalho "ctor"
    {
        Nome = nome;
        this.Preco = Preco;
    }

    public string? Nome { get; set; }

    public double Preco { get; set; }
}