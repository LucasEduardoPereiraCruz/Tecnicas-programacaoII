using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    internal class Fabricas
    {
        public string Nome { get; set; }

        private ICollection<Maquina> Maquinas = new List<Maquina>();

        public void AdicionarMaquina(Maquina maquina)
        {
            Maquinas.Add(maquina); 
        }

        public void ListarMaquinas()
        {
            foreach(var maquina in Maquinas)
            {
                Console.WriteLine($"{maquina.Nome} {maquina.Modelo} {maquina.DataFabricacao} {maquina.NumeroSerie}");
            }
        }

        public Maquina BuscarMaquinaPorModelo(string modelo)
        {
            var maquina = Maquinas.FirstOrDefault(m => m.Modelo == modelo);

            if (maquina == null)
                throw new Exception("Máquina não encontrada");

            return maquina;
        }
    }
}
