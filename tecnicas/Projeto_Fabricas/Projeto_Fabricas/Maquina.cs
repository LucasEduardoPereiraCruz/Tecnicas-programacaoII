using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class Maquina
    {
        // Modelo da máquina
        public string Modelo { get; set; }

        // Horário/operação da máquina
        public string HoraOperacao { get; set; }

        // Gera automaticamente um número único
        public Guid NumeroSerie { get; } = Guid.NewGuid();

        // private get = só pode ler dentro da própria classe
        public string Observacao { private get; set; }

        // Equipamento relacionado à máquina
        public Equipamento Equipamento { get; set; }
    }
}