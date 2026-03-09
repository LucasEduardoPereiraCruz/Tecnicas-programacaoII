// Composição do lado de pessoa (Bilateral) Pessoa -> Celular
using Composição;

Pessoa pessoa1 = new Pessoa("Pedro", 14, "999999999");
pessoa1.SetCelular(14, "988888888");

Console.WriteLine("Composição do lado do Todo(Pessoa-Celular)");
Console.WriteLine($"Nome: {pessoa1.Nome}");

foreach (var dado in pessoa1.Celulares)
{
    Console.WriteLine($"DDD: ({dado.DDD}) - {dado.Numero}");
}

// Composição do lado do Celular(Bilateral) Celular -> Pessoa
Pessoa pessoa2 = new Pessoa("Paulo");

Celular cel1 = new Celular(14, "977777777", pessoa2);

Console.WriteLine("Composição do lado do Todo(Pessoa-Celular)");
Console.WriteLine($"Nome: {cel1.ProprietarioCelular.Nome} - Celular({cel1.DDD}){cel1.Numero}");
