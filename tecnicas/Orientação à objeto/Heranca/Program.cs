// See https://aka.ms/new-console-template for more information
Aluno aluno1 = new Aluno("Paulo", "111.111.111-11", "20269818188");

Console.WriteLine($"Nome: {aluno1.Nome}\nCPF:{aluno1.Cpf}\nRA:{aluno1.Ra}");

Console.WriteLine("Digite o nome do professor"); // Instanciando um professor pelo console 
var nomeProf = Console.ReadLine();

Console.WriteLine("Digite o cpf do professor"); // Instanciando um professor pelo console 
var cpfProf = Console.ReadLine();

Console.WriteLine("Digite a titulação do professor"); // Instanciando um professor pelo console 
var titualacaoProf = Console.ReadLine();

Professor prof1 = new Professor(nomeProf, cpfProf, titualacaoProf);
Professor.Exibir(prof1);

Console.ReadKey();

public class Pessoa
{
    public Pessoa(string? nome, string? cpf)
    {
        Nome = nome;
        Cpf = cpf;  
    }

    public string? Nome { get; set; }
    public string? Cpf { get; set; }
}


public class Aluno:Pessoa
{
    public Aluno(string? nome, string? cpf, string ra):base(nome, cpf)
    {
        Ra = ra;      
    }

    public string? Ra { get; set; }
}

public class Professor : Pessoa
{
    public Professor(string? nome, string? cpf, string? titulacao) : base(nome, cpf)
    {
        Titulacao = titulacao;
    }

    public string? Titulacao { get; set; }


    public static void Exibir(Professor prof) => Console.WriteLine($"{prof.Nome}\n{prof.Cpf}\n" + $"{prof.Titulacao}");
 

    public string? titulacao { get; set; }

}