Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();

// Registrar as classes assinantes 
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;

pedido.criarPedido();

Console.WriteLine("Fim do pedido");

Console.ReadKey();
delegate void PedidoEvent();

class Pedido
{
    public event PedidoEvent? OnCriarPedido;

    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if(OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class EnviarEmail
{
    public static void email()
    {
        Console.WriteLine("E-mail enviado");
    }
}


class EnviarSMS
{
    public static void sms()
    {
        Console.WriteLine("SMS enviado");
    }
}
