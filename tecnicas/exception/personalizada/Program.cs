ContaBancaria conta = new ContaBancaria(300.00m);

try
{
    conta.Sacar("100");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Erro de saldo:" + ex.Message);
}

try
{
    conta.Sacar("500");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Erro de saldo:" + ex.Message);
}

try
{
    conta.Sacar("asdaasda");
}
catch (ApplicationException ex)
{
    Console.WriteLine(ex.Message);
}

public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(string valorTexto)
    {
        try
        {
            decimal valor = decimal.Parse(valorTexto);
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException($"Saldo Insuficiente. Saldo atual: R${Saldo}. Tentativa de saque na valor de R${valor}");
            }
            Saldo -= valor;
            Console.WriteLine($"Saldo atual: R${Saldo}");
        } // fim do try
        catch(FormatException fe)
        {
            throw new ApplicationException("Erro ao converter valor do saque", fe);
        }
        finally
        {
            Console.WriteLine("Fim do saque");
        }
    } // fim do método
} // fim da classe 

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }

    public SaldoInsuficienteException(string message) : base(message) { }

    public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException) { }
}