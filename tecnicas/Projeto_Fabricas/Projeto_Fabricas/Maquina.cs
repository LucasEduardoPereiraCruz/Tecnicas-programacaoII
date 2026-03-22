using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class Maquina
    {
        public string Modelo { get; set; }
        public string HoraOperacao { get; set; }

        public Guid NumeroSerie { get; } = Guid.NewGuid();

        public string Observacao { private get; set; } 
        public Equipamento Equipamento { get; set; }
    }
}
