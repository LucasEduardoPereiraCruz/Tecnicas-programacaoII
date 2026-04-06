using System.Runtime.CompilerServices;

Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();

// Registrar as classes assinantes 
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;

pedido.criarPedido();

Console.WriteLine("Fim do pedido");

Console.ReadKey();


class Pedido
{
    public event EventHandler? OnCriarPedido;

    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}

class EnviarEmail
{
    public static void email(Object? sander, EventArgs e)
    {
        Console.WriteLine("E-mail enviado");
    }
}


class EnviarSMS
{
    public static void sms(Object? sander, EventArgs e)
    {
        Console.WriteLine("SMS enviado");
    }
}

