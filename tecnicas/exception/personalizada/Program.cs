// Cria uma conta bancária com saldo inicial de 300 reais
ContaBancaria conta = new ContaBancaria(300.00m);



// Tenta sacar 100 reais
try
{
    conta.Sacar("100");
}

// Captura exceção personalizada de saldo insuficiente
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Erro de saldo:" + ex.Message);
}



// Tenta sacar 500 reais
// Vai gerar exceção pois o saldo não é suficiente
try
{
    conta.Sacar("500");
}

// Captura exceção personalizada
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Erro de saldo:" + ex.Message);
}



// Tenta converter texto inválido para decimal
try
{
    conta.Sacar("asdaasda");
}

// Captura exceção de aplicação
catch (ApplicationException ex)
{
    Console.WriteLine(ex.Message);
}



// Classe da conta bancária
public class ContaBancaria
{
    // Saldo da conta
    // private set = só pode alterar dentro da classe
    public decimal Saldo { get; private set; }

    // Construtor
    public ContaBancaria(decimal saldoInicial)
    {
        // Define o saldo inicial
        Saldo = saldoInicial;
    }

    // Método para sacar dinheiro
    public void Sacar(string valorTexto)
    {
        try
        {
            // Converte texto para decimal
            decimal valor = decimal.Parse(valorTexto);

            // Verifica se o valor é maior que o saldo
            if (valor > Saldo)
            {
                // Lança exceção personalizada
                throw new SaldoInsuficienteException(
                    $"Saldo Insuficiente. Saldo atual: R${Saldo}. Tentativa de saque na valor de R${valor}"
                );
            }

            // Subtrai valor do saldo
            Saldo -= valor;

            // Exibe saldo atual
            Console.WriteLine($"Saldo atual: R${Saldo}");

        } // fim do try


        // Captura erro de conversão
        catch (FormatException fe)
        {
            // Lança nova exceção personalizada
            // fe = exceção original
            throw new ApplicationException(
                "Erro ao converter valor do saque",
                fe
            );
        }


        // Sempre executa
        finally
        {
            Console.WriteLine("Fim do saque");
        }

    } // fim do método

} // fim da classe 



// Classe de exceção personalizada
// Herda da classe Exception
public class SaldoInsuficienteException : Exception
{
    // Construtor vazio
    public SaldoInsuficienteException() { }

    // Construtor recebendo mensagem
    public SaldoInsuficienteException(string message)
        : base(message) { }

    // Construtor recebendo mensagem e exceção interna
    public SaldoInsuficienteException(
        string message,
        Exception innerException
    ) : base(message, innerException) { }
}