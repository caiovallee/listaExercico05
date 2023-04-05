using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Consumo_por_litro
    {
        internal double consumoCombustivel;
        internal double quilometragemInicial;
        internal double quilometragemFinal;

        internal double CalcularConsumoKm()
        {
            return (quilometragemFinal - quilometragemInicial) / consumoCombustivel;
        }
    }
}
