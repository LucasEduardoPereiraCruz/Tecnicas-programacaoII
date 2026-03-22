using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class Fabrica
    {
        public string Nome { get; set; }

        private List<Maquina> maquinas = new List<Maquina>();

        public void AdicionarMaquina(Maquina maquina)
        {
            maquinas.Add(maquina);
        }

        public void ListarMaquinas()
        {
            for (int i = 0; i < maquinas.Count; i++)
            {
                var maquina = maquinas[i];

                Console.WriteLine(
                    $"{maquina.Equipamento.Nome} " +
                    $"{maquina.Modelo} " +
                    $"{maquina.Equipamento.DataFabricacao} " +
                    $"{maquina.NumeroSerie}"
                );
            }
        }

        public Maquina BuscarMaquinaPorModelo(string modelo)
        {
            for (int i = 0; i < maquinas.Count; i++)
            {
                if (maquinas[i].Modelo == modelo)
                {
                    return maquinas[i];
                }
            }

            return null; // ESSENCIAL
        }
    }
}
