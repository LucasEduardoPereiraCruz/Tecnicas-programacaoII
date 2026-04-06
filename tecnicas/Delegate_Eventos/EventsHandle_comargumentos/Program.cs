using System.Runtime.CompilerServices;

Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();

// Registrar as classes assinantes 
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;
pedido.criarPedido("maria@gmail.com", "(14)999999999");


Console.WriteLine("Fim do pedido");

Console.ReadKey();

class PedidoEventsArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

    class Pedido
    {
        public event EventHandler<PedidoEventsArgs>? OnCriarPedido;

        public void criarPedido(string email, string telefone)
        {
            Console.WriteLine("Iniciando o criar pedido");
            if (OnCriarPedido != null)
            {
                OnCriarPedido(this, new PedidoEventsArgs
                {
                    Email = email,
                    Telefone = telefone
                }
                );
            }
        }
    }

    class EnviarEmail
    {
        public static void email(Object? sander, PedidoEventsArgs e)
        {
            Console.WriteLine($"E-mail enviado para {e.Email}");
        }
    }


    class EnviarSMS
    {
        public static void sms(Object? sander, PedidoEventsArgs e)
        {
            Console.WriteLine($"SMS enviado para {e.Telefone}");
        }
    }

