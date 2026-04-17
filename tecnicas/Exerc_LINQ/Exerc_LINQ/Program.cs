

public static class Extensoes // static não precisa criar obj (new) 
{
    public static int SomarImpares(this List<int> lista) // Adicionando um método na List<int>
    {
        return lista.Where(x => x % 2 != 0).Sum(); // Filtra só os núemros impares
        // x % 2  resto da divisão por 2 - != 0 Se for diferente de 0 é impar 
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
}

class Pedido
{
    public int Quantidade { get; set; }
    public DateTime dataPedido { get; set; }
    public Produto Produto { get; set; }
    public Cliente Cliente { get; set; }
}


class Program
{
    static void Main() // Execução 
    {

        // EXERCÍCIO 1 - soma dos impares
        List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

        int somaImpares = numeros.SomarImpares(); // chama o método de extensão 
        Console.WriteLine("Soma dos ímpares: " + somaImpares);


        // EXERCÍCIO 2
        int maior = numeros.Max();
        Console.WriteLine("Maior número: " + maior);

        int soma = numeros.Where(x => x > 10).Sum();
        Console.WriteLine("Soma > 10: " + soma);


        // EXERCÍCIO 3
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 17 },
            new Pessoa { Nome = "Maria", Idade = 22 },
            new Pessoa { Nome = "Carlos", Idade = 30 }
        };

        var maiores = pessoas.Where(p => p.Idade > 18);

        Console.WriteLine("\nMaiores de idade:");
        foreach (var p in maiores)
        {
            Console.WriteLine(p.Nome);
        }

        var nomes = pessoas
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome);

        Console.WriteLine("\nNomes ordenados:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }


        // EXERCÍCIO 4
        var cliente1 = new Cliente { Nome = "Lucas", CPF = "111" };
        var cliente2 = new Cliente { Nome = "Ana", CPF = "222" };

        var pedidos = new List<Pedido>
        {
            new Pedido
            {
                Cliente = cliente1,
                Produto = new Produto { Nome = "Mouse", Preco = 100 },
                Quantidade = 2,
                dataPedido = DateTime.Now
            },
            new Pedido
            {
                Cliente = cliente1,
                Produto = new Produto { Nome = "Monitor", Preco = 800 },
                Quantidade = 1,
                dataPedido = DateTime.Now
            },
            new Pedido
            {
                Cliente = cliente2,
                Produto = new Produto { Nome = "Teclado", Preco = 300 },
                Quantidade = 1,
                dataPedido = DateTime.Now
            }
        };

        // a) Agrupar pedidos por cliente
        var agrupado = pedidos.GroupBy(p => p.Cliente.Nome);

        Console.WriteLine("\nPedidos por cliente:");
        foreach (var grupo in agrupado)
        {
            Console.WriteLine(grupo.Key);

            foreach (var pedido in grupo)
            {
                Console.WriteLine("- " + pedido.Produto.Nome);
            }
        }

        // b) Clientes com pedidos acima de R$500
        var clientes = pedidos
            .Where(p => p.Produto.Preco * p.Quantidade > 500)
            .Select(p => p.Cliente.Nome)
            .Distinct();

        Console.WriteLine("\nClientes com pedidos > 500:");
        foreach (var nome in clientes)
        {
            Console.WriteLine(nome);
        }

        // c) Total de pedidos por cliente
        var total = pedidos
            .GroupBy(p => p.Cliente.Nome)
            .Select(g => new
            {
                Cliente = g.Key,
                Total = g.Sum(p => p.Produto.Preco * p.Quantidade)
            });

        Console.WriteLine("\nTotal por cliente:");
        foreach (var item in total)
        {
            Console.WriteLine(item.Cliente + " - " + item.Total);
        }
    }
}