using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace RegistroMultas
{

    // Delegate usado no evento
    // Métodos inscritos precisam receber uma Multa
    public delegate void MultaHandler(Multa m);

    public class CentralDeMultas
    {
        // Evento 
        public event MultaHandler MultaRegistrada;

        // Lista
        public List<Multa> multas = new List<Multa>(); // vira texto JSON

        // Registrar Multa
        public void Registrar(Multa m)
        {
            // Adiciona multa na lista
            multas.Add(m);

            Console.WriteLine("Multa Registrada");

            // Dispara o evento
            MultaRegistrada?.Invoke(m);
        }

        // Salvar em JSON
        public void SalvarJson(string caminho)
        {
            // Serialize converte objeto C# em JSON
            string json = JsonSerializer.Serialize(multas); // Converte em Json

            // Cria/escreve arquivo JSON
            File.WriteAllText(caminho, json);
        }


        // Carregar JSON
        public void CarregarJson(string caminho)
        {
            // Verifica se o arquivo realmente existe
            if (File.Exists(caminho))
            {
                // Lê TODO o conteúdo do arquivo
                // e guarda em uma string chamada json
                string json = File.ReadAllText(caminho);


                // Converte o texto JSON novamente para uma Lista de Multa
                // Deserialize = transformar texto JSON em objeto C#
                multas = JsonSerializer.Deserialize<List<Multa>>(json);
            }
        }
    }
}