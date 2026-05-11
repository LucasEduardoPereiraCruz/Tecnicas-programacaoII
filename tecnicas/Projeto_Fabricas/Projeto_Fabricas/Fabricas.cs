using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class Fabrica
    {
        // Nome da fábrica
        public string Nome { get; set; }

        // Lista privada de máquinas
        private List<Maquina> maquinas = new List<Maquina>();

        public void AdicionarMaquina(Maquina maquina)
        {
            // Adiciona máquina na lista
            maquinas.Add(maquina);
        }

        public void ListarMaquinas()
        {
            // Percorre lista de máquinas
            for (int i = 0; i < maquinas.Count; i++)
            {
                // Pega máquina atual
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
            // Percorre lista procurando modelo
            for (int i = 0; i < maquinas.Count; i++)
            {
                // Verifica se encontrou modelo
                if (maquinas[i].Modelo == modelo)
                {
                    // Retorna máquina encontrada
                    return maquinas[i];
                }
            }

            return null; // ESSENCIAL
        }
    }
}