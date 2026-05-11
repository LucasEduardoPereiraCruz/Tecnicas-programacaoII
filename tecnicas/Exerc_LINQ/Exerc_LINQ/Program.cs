public static class Extensoes // static não precisa criar obj (new) 
{
    public static int SomarImpares(this List<int> lista) // Adicionando um método na List<int>
    {
        return lista.Where(x => x % 2 != 0).Sum(); // Filtra só os núemros impares
        // x % 2  resto da divisão por 2 - != 0 Se for diferente de 0 é impar 
        // Sum() soma todos os valores encontrados
    }
}

class Pessoa
{
    // Nome da pessoa
    public string Nome { get; set; }

    // Idade da pessoa
    public int Idade { get; set; }
}

class Produto
{
    // Nome do produto
    public string Nome { get; set; }

    // Preço do produto
    public decimal Preco { get; set; }
}

class Cliente
{
    // Nome do cliente
    public string Nome { get; set; }

    // CPF do cliente
    public string CPF { get; set; }
}

class Pedido
{
    // Quantidade do produto no pedido
    public int Quantidade { get; set; }

    // Data do pedido
    public DateTime dataPedido { get; set; }

    // Produto comprado
    public Produto Produto { get; set; }

    // Cliente que realizou o pedido
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

        // Max() pega o maior valor da coleção
        int maior = numeros.Max();

        Console.WriteLine("Maior número: " + maior);

        // Filtra números maiores que 10 e soma eles
        int soma = numeros.Where(x => x > 10).Sum();

        Console.WriteLine("Soma > 10: " + soma);


        // EXERCÍCIO 3
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 17 },
            new Pessoa { Nome = "Maria", Idade = 22 },
            new Pessoa { Nome = "Carlos", Idade = 30 }
        };

        // Filtra pessoas maiores de idade
        var maiores = pessoas.Where(p => p.Idade > 18);

        Console.WriteLine("\nMaiores de idade:");

        // Percorre pessoas filtradas
        foreach (var p in maiores)
        {
            Console.WriteLine(p.Nome);
        }

        // OrderBy ordena pelo nome
        // Select pega apenas o nome
        var nomes = pessoas
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome);

        Console.WriteLine("\nNomes ordenados:");

        // Percorre nomes ordenados
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }


        // EXERCÍCIO 4

        // Criando clientes
        var cliente1 = new Cliente { Nome = "Lucas", CPF = "111" };
        var cliente2 = new Cliente { Nome = "Ana", CPF = "222" };

        // Lista de pedidos
        var pedidos = new List<Pedido>
        {
            new Pedido
            {
                Cliente = cliente1,

                Produto = new Produto
                {
                    Nome = "Mouse",
                    Preco = 100
                },

                Quantidade = 2,

                // Pega data atual do sistema
                dataPedido = DateTime.Now
            },

            new Pedido
            {
                Cliente = cliente1,

                Produto = new Produto
                {
                    Nome = "Monitor",
                    Preco = 800
                },

                Quantidade = 1,

                dataPedido = DateTime.Now
            },

            new Pedido
            {
                Cliente = cliente2,

                Produto = new Produto
                {
                    Nome = "Teclado",
                    Preco = 300
                },

                Quantidade = 1,

                dataPedido = DateTime.Now
            }
        };

        // a) Agrupar pedidos por cliente

        // GroupBy agrupa pedidos pelo nome do cliente
        var agrupado = pedidos.GroupBy(p => p.Cliente.Nome);

        Console.WriteLine("\nPedidos por cliente:");

        // Percorre cada grupo
        foreach (var grupo in agrupado)
        {
            // Key representa a chave do agrupamento
            Console.WriteLine(grupo.Key);

            // Percorre pedidos daquele cliente
            foreach (var pedido in grupo)
            {
                Console.WriteLine("- " + pedido.Produto.Nome);
            }
        }

        // b) Clientes com pedidos acima de R$500

        var clientes = pedidos

            // Filtra pedidos acima de 500
            .Where(p => p.Produto.Preco * p.Quantidade > 500)

            // Seleciona apenas o nome do cliente
            .Select(p => p.Cliente.Nome)

            // Remove nomes repetidos
            .Distinct();

        Console.WriteLine("\nClientes com pedidos > 500:");

        // Percorre clientes encontrados
        foreach (var nome in clientes)
        {
            Console.WriteLine(nome);
        }

        // c) Total de pedidos por cliente

        var total = pedidos

            // Agrupa pedidos por cliente
            .GroupBy(p => p.Cliente.Nome)

            // Cria tipo anônimo com cliente e total gasto
            .Select(g => new
            {
                Cliente = g.Key,

                // Soma total gasto pelo cliente
                Total = g.Sum(p => p.Produto.Preco * p.Quantidade)
            });

        Console.WriteLine("\nTotal por cliente:");

        // Exibe total de cada cliente
        foreach (var item in total)
        {
            Console.WriteLine(item.Cliente + " - " + item.Total);
        }
    }
}