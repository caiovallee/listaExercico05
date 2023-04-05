using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Caixa_Retangular
    {
        public int largura;
        public int comprimento;
        public int altura;

        public decimal CalcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}
