// Exibe mensagem inicial
Console.WriteLine("Usando evento");

// Cria um objeto Pedido
Pedido pedido = new Pedido();


// Registra métodos assinantes no evento
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;


// Executa o método criarPedido
pedido.criarPedido();


// Exibe mensagem final
Console.WriteLine("Fim do pedido");

// Aguarda tecla
Console.ReadKey();


// Cria um delegate sem parâmetros
delegate void PedidoEvent(); // Esse delegate NÃO recebe parâmetros.


// Classe Pedido
class Pedido
{
    // Declara um evento baseado no delegate PedidoEvent
    public event PedidoEvent? OnCriarPedido;

    // Método que cria pedido
    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");

        // Verifica se o evento possui assinantes
        if (OnCriarPedido != null)
        {
            // Dispara o evento
            // Todos os métodos inscritos serão executados
            OnCriarPedido();
        }
    }
}


// Classe para envio de e-mail
class EnviarEmail
{
    // Método executado quando o evento ocorrer
    public static void email() // Então os métodos também não podem receber parametros 
    {
        Console.WriteLine("E-mail enviado");
    }
}


// Classe para envio de SMS
class EnviarSMS
{
    // Método executado quando o evento ocorrer
    public static void sms() // Então os métodos também não podem receber parametros
    {
        Console.WriteLine("SMS enviado");
    }
}