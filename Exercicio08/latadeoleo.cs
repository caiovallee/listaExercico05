using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class latadeoleo
    {
        internal double altura;
        internal double raio;

        internal double CalcularVolume()
        {
            return (Math.PI * (raio * raio) * altura);
        }
    }
}
