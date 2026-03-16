using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    internal class Maquina : Equipamento
    {   
        public string Modelo { get; set; }
        public string HoraOperacao { get; set; }
        public Guid NumeroSerie { get; } = Guid.NewGuid();
        public string Observacao { get; set; } // !!!!
    }
}
