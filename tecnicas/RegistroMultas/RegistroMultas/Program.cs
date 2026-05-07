using RegistroMultas;
using System.Linq;

class Program
{
    static void Main()
    {
        // Cria a central
        CentralDeMultas central = new CentralDeMultas();

        // Conecta o evento
        central.MultaRegistrada += VerificarMultaGrave; // Adicionar um método ao evento ----- Remover método do evento

        // PRIMEIRA MULTA
        central.Registrar(new Multa()
        {
            Placa = "ABC1234",
            TipoInfracao = "Excesso de velocidade",
            Valor = 700,
            Data = DateTime.Now
        });

        // SEGUNDA MULTA
        central.Registrar(new Multa()
        {
            Placa = "XYZ9999",
            TipoInfracao = "Avanço de sinal",
            Valor = 300,
            Data = DateTime.Now
        });

        // TERCEIRA MULTA
        central.Registrar(new Multa()
        {
            Placa = "JKL4567",
            TipoInfracao = "Estacionamento proibido",
            Valor = 150,
            Data = DateTime.Now
        });

        // QUARTA MULTA
        central.Registrar(new Multa()
        {
            Placa = "QWE8521",
            TipoInfracao = "Dirigindo sem cinto",
            Valor = 550,
            Data = DateTime.Now
        });

        // Salvar JSON
        central.SalvarJson("multas.json");

        // LINQ
        var multasGraves = central.multas
            .Where(m => m.Valor > 500);

        Console.WriteLine("\nMULTAS ACIMA DE 500:\n");

        foreach (var m in multasGraves)
        {
            Console.WriteLine($"Placa: {m.Placa}");
            Console.WriteLine($"Infração: {m.TipoInfracao}");
            Console.WriteLine($"Valor: R$ {m.Valor}");
            Console.WriteLine("-------------------");
        }
    }

    // Método do evento
    static void VerificarMultaGrave(Multa m)
    {
        if (m.Valor > 500)
        {
            Console.WriteLine("MULTA GRAVE DETECTADA!");
        }
    }
}