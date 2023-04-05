using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Volume_Esfera
    {
        internal double raio;

        internal double CalcularVolume()
        {
            return (4 / 3) * Math.PI * (Math.Pow(raio, 3));
        }
    }
}
