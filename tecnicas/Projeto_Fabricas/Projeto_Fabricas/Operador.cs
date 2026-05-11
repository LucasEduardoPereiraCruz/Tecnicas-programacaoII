using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    using System;
    using System.Threading.Tasks;

    namespace Projeto_Fabricas
    {
        public class Operador
        {
            // Nome do operador
            public string Nome { get; set; }

            // Método assíncrono para operar máquina
            public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
            {
                Console.WriteLine($"{Nome} está tentando operar a máquina modelo {modelo}");

                // Espera 2 segundos sem travar programa
                await Task.Delay(2000);

                // Busca máquina pelo modelo
                Maquina maquina = fabrica.BuscarMaquinaPorModelo(modelo);

                // Verifica se máquina não foi encontrada
                if (maquina == null)
                {
                    throw new Exception($"Máquina modelo {modelo} não encontrada na {fabrica.Nome}");
                }

                Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");

                // Espera mais 3 segundos
                await Task.Delay(3000);
            }
        }
    }
}   