using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class Equipamento
    {
        // Nome do equipamento
        public string Nome { get; set; }

        // Data de fabricação do equipamento
        public DateTime DataFabricacao { get; set; }

    }
}