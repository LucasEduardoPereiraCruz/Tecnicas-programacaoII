using Projeto_Fabricas.Projeto_Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Fabrica fabrica = new Fabrica();
            fabrica.Nome = "Fabrica Fatec";

            // Criar equipamentos
            Equipamento e1 = new Equipamento
            {
                Nome = "Maquina A",
                DataFabricacao = DateTime.Now
            };

            Equipamento e2 = new Equipamento
            {
                Nome = "Maquina B",
                DataFabricacao = DateTime.Now
            };

            // Criar maquinas
            Maquina m1 = new Maquina
            {
                Modelo = "ABC123",
                HoraOperacao = "10h",
                Equipamento = e1
            };

            Maquina m2 = new Maquina
            {
                Modelo = "XYZ999",
                HoraOperacao = "8h",
                Equipamento = e2
            };

            // Adicionando na fábrica
            fabrica.AdicionarMaquina(m1);
            fabrica.AdicionarMaquina(m2);

            // Listar
            Console.WriteLine("Máquinas cadastradas:");
            fabrica.ListarMaquinas();

            // Operador
            Operador operador = new Operador
            {
                Nome = "Lucas"
            };

            try
            {
                await operador.OperarMaquinaAsync(fabrica, "ABC123");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                await operador.OperarMaquinaAsync(fabrica, "ABC12345");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}