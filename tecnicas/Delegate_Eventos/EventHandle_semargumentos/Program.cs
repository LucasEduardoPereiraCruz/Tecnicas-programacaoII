// Importa bibliotecas do .NET
using System.Runtime.CompilerServices;

// Exibe mensagem inicial
Console.WriteLine("Usando evento");

// Cria um objeto Pedido
Pedido pedido = new Pedido();


// Registra métodos no evento
// Quando o evento acontecer, esses métodos serão chamados
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;


// Executa o método criarPedido
pedido.criarPedido();

// Exibe mensagem final
Console.WriteLine("Fim do pedido");

// Aguarda uma tecla
Console.ReadKey();


// Classe Pedido
class Pedido
{
    // Declara um evento usando EventHandler
    // EventHandler já é um delegate pronto do C#
    public event EventHandler? OnCriarPedido; // Isso influencia la em baixo no EMAIL e SMS (está comentado)

    // Método para criar pedido
    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");

        // Verifica se existe alguém inscrito no evento
        if (OnCriarPedido != null)
        {
            // Dispara o evento
            // this = objeto atual que disparou o evento
            // EventArgs.Empty = sem argumentos extras
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}


// Classe responsável por enviar e-mail
class EnviarEmail
{
    // Método chamado quando o evento acontecer
    public static void email(Object? sander, EventArgs e) // O EventHandler já vem pronto no C# e exige obrigatoriamente 
    {
        Console.WriteLine("E-mail enviado");
    }
}


// Classe responsável por enviar SMS
class EnviarSMS
{
    // Método chamado quando o evento acontecer
    public static void sms(Object? sander, EventArgs e) // O EventHandler já vem pronto no C# e exige obrigatoriamente
    {
        Console.WriteLine("SMS enviado");
    }
}