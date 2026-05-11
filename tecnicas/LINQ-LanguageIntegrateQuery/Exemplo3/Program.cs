// Obtém lista de produtos
var listaProdutos = Produto.GetProdutos();



// Exibe título
Console.WriteLine("Produtos Eletrônicos");


// Filtra produtos da categoria Eletrônicos
var produtosEletronicos = listaProdutos
    .Where(p => p.Categoria == "Eletrônicos");


// Exibe produtos encontrados
Produto.Mostrar(produtosEletronicos);


Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Produtos caros com estoque maior do que 5");


// Filtra produtos:
// preço >= 1000 E estoque > 5
var produtosCaros = listaProdutos
    .Where(p => p.Preco >= 1000 && p.Estoque > 5);


// Exibe produtos filtrados
Produto.Mostrar(produtosCaros);


Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Produtos caros com estoque menor que 15 ordenado pelo nome ");


// Filtra produtos com preço menor que 15
// Depois ordena pelo nome
var estoqueBaixo = listaProdutos
    .Where(p => p.Preco < 15)
    .OrderBy(p => p.Nome);


// Exibe resultado
Produto.Mostrar(estoqueBaixo);


Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Produtos ordenados por categoria e nome");


// Ordena primeiro pela categoria
// Depois pelo nome
var produtosOrdenados = listaProdutos
    .OrderBy(p => p.Categoria)
    .ThenBy(p => p.Nome);


Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Filtrando preços menor do que 500 com aumento de 10% ordenado por nome e criando um tipo anônimo");


// Where -> filtra preços menores que 500
// OrderBy -> ordena por nome
// Select -> cria novo objeto anônimo

var resultado = listaProdutos
    .Where(p => p.Preco < 500)
    .OrderBy(p => p.Nome)
    .Select(p => new
    {
        // Nome em maiúsculo
        nomeProduto = p.Nome.ToUpper(),

        // Aumenta preço em 10%
        precoModificado = p.Preco * 1.1
    });


// Exibe resultado
Produto.MostrarTipoAnonimo(resultado);

Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Valor médio dos preços dos eletrônicos");


// Filtra eletrônicos
// Average calcula média dos preços
double media = listaProdutos
    .Where(p => p.Categoria == "Eletrônicos")
    .Average(p => p.Preco);


// Exibe média
Console.WriteLine($"Média = {media}");

Console.WriteLine("===============================");



// Exibe título
Console.WriteLine("Selecionar produtos com preços maior do que 200 com desconto de 20% ordenado por preço e um tipo anônimo");


// Filtra produtos > 200
// Ordena pelo preço
// Cria objeto anônimo com desconto
var resultado2 = listaProdutos
    .Where(p => p.Preco > 200)
    .OrderBy(p => p.Preco)
    .Select(p => new
    {
        nomeProduto = p.Nome.ToUpper(),

        // Aplica desconto de 20%
        precoModificado = p.Preco * 0.8
    });


// Exibe resultado
Produto.MostrarTipoAnonimo(resultado2);

Console.WriteLine("===============================");



// Aguarda tecla
Console.ReadKey();




// Classe Produto
public class Produto
{
    // Id do produto
    public int Id { get; set; }

    // Nome do produto
    public string? Nome { get; set; }

    // Preço do produto
    public double Preco { get; set; }

    // Quantidade em estoque
    public int Estoque { get; set; }

    // Categoria do produto
    public string? Categoria { get; set; }



    // Método que retorna lista de produtos
    public static List<Produto> GetProdutos()
    {
        // Cria lista de produtos
        List<Produto> produtos = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Camiseta", Preco = 29.99, Estoque = 50, Categoria = "Roupa"},
            new Produto { Id = 2, Nome = "Meia", Preco = 20.99, Estoque = 100, Categoria = "Roupa"},
            new Produto { Id = 3, Nome = "Tenis Nike", Preco = 400.50, Estoque = 10, Categoria = "Calçados"},
            new Produto { Id = 4, Nome = "Celular", Preco = 5000, Estoque = 150, Categoria = "Eletrônicos"},
            new Produto { Id = 5, Nome = "Mochila", Preco = 150.15, Estoque = 50, Categoria = "Acessórios"},
            new Produto { Id = 6, Nome = "Relógio", Preco = 320.99, Estoque = 15, Categoria = "Acessórios"},
            new Produto { Id = 7, Nome = "Cadeira", Preco = 930, Estoque = 30, Categoria = "Móveis"},
            new Produto { Id = 8, Nome = "Mesa", Preco = 260.20, Estoque = 150, Categoria = "Móveis"},
            new Produto { Id = 9, Nome = "Smart TV", Preco = 1500.00, Estoque = 5, Categoria = "Eletrônicos"},
            new Produto { Id = 10, Nome = "Notebook", Preco = 6900.75, Estoque = 100, Categoria = "Eletrônicos"}
        };

        // Retorna lista pronta
        return produtos;
    }



    // Método para exibir produtos
    //o método foi feito para aceitar QUALQUER coleção de Produto, não só List<Produto>  
    public static void Mostrar(IEnumerable<Produto> produtos) // "qualquer coleção que possa ser percorrida com foreach" O RESPONSÁVEL POR ISSO É O IENUMERABLE 
    {
        // Percorre cada produto
        foreach (var item in produtos)
        {
            Console.WriteLine(
                $"{item.Id} - {item.Nome} - {item.Preco} - {item.Estoque} - {item.Categoria}"
            );
        }
    }



    // Método para exibir tipos anônimos
    public static void MostrarTipoAnonimo(IEnumerable<dynamic> produtos)
    {
        // Percorre cada item
        foreach (var item in produtos)
        {
            Console.WriteLine(
                $"{item.nomeProduto} - {item.precoModificado}"
            );
        }
    }
}