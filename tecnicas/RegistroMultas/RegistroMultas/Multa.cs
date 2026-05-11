using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroMultas
{
    public class Multa
    {
        // Placa do veículo
        public string Placa { get; set; }

        // Tipo da infração
        public string TipoInfracao { get; set; }

        // Valor da multa
        public double Valor { get; set; }

        // Data da multa
        public DateTime Data { get; set; }
    }
}