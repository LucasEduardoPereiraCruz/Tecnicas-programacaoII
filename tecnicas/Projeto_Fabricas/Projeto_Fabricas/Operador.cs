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
            public string Nome { get; set; }

            public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
            {
                Console.WriteLine($"{Nome} está tentando operar a máquina modelo {modelo}");
                await Task.Delay(2000);

                Maquina maquina = fabrica.BuscarMaquinaPorModelo(modelo);

                if (maquina == null)
                {
                    throw new Exception($"Máquina modelo {modelo} não encontrada na {fabrica.Nome}");
                }

                Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");
                await Task.Delay(3000);
            }
        }
    }
}