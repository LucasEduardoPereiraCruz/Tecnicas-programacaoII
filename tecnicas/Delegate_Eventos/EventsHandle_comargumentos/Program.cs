// Importa bibliotecas do .NET
using System.Runtime.CompilerServices;

// Exibe mensagem inicial
Console.WriteLine("Usando evento");

// Cria objeto Pedido
Pedido pedido = new Pedido();


// Registra os métodos no evento
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;


// Cria pedido enviando email e telefone
pedido.criarPedido("maria@gmail.com", "(14)999999999");


// Exibe mensagem final
Console.WriteLine("Fim do pedido");

// Aguarda tecla
Console.ReadKey();


// Classe que armazena os dados do evento
// Herda de EventArgs pois é padrão do C#
class PedidoEventsArgs : EventArgs
{
    // Propriedade Email
    public string? Email { get; set; }

    // Propriedade Telefone
    public string? Telefone { get; set; }
}


// Classe Pedido
class Pedido
{
    // Evento usando EventHandler com argumentos personalizados
    public event EventHandler<PedidoEventsArgs>? OnCriarPedido; // Agora o evento usa uma classe personalizada (PedidoEventsArgs).

    // Método para criar pedido
    public void criarPedido(string email, string telefone)
    {
        Console.WriteLine("Iniciando o criar pedido");

        // Verifica se existem assinantes no evento
        if (OnCriarPedido != null)
        {
            // Dispara o evento enviando os dados
            OnCriarPedido(this, new PedidoEventsArgs
            {
                // Preenche a propriedade Email
                Email = email,

                // Preenche a propriedade Telefone
                Telefone = telefone
            }
            );
        }
    }
}


// Classe responsável por enviar e-mail
class EnviarEmail
{
    // Método chamado quando o evento acontecer
    public static void email(Object? sander, PedidoEventsArgs e) // Então os métodos precisam receber (classe pedido)
    {
        // Usa os dados recebidos do evento
        Console.WriteLine($"E-mail enviado para {e.Email}");
    }
}


// Classe responsável por enviar SMS
class EnviarSMS
{
    // Método chamado quando o evento acontecer
    public static void sms(Object? sander, PedidoEventsArgs e) // Então os métodos precisam receber (classe pedido)
    {
        // Usa os dados recebidos do evento
        Console.WriteLine($"SMS enviado para {e.Telefone}");
    }
}