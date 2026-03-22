using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fabricas
{
    public class MaquinaNaoEncontradaException : Exception
    {
        public MaquinaNaoEncontradaException(string mensagem) : base(mensagem)
        {
        }
    }
}